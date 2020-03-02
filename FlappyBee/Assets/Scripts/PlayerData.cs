using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{
		private SpriteRenderer _beeSpriteRenderer;
		[SerializeField]
		private Text _scoreCountText;
		private int _score;
		[SerializeField]
		private int _hp;
		[SerializeField]
		private HpBar _hpBar;
		[SerializeField]
		private GameOverWindow _gameOverWindow;
		[Tooltip("Время в течении которого пчела будет бессмертна после получения урона")]
		public float GodModeTimeAfterDamage = 0f;

		private void Awake()
		{
				_beeSpriteRenderer = GetComponentInChildren<SpriteRenderer>();
				_hpBar?.UpdateHp(_hp);
		}

		public void GetDamage()
		{
				_hp--;
				_hpBar?.UpdateHp(_hp);

				if(_hp <= 0)
				{
						_gameOverWindow.SetScore(_score);
						_gameOverWindow.gameObject.SetActive(true);
				}
				else
				{
						AnimateGodMode();
				}
		}

		public void AddScore(int score)
		{
				_score+=score;
				_scoreCountText.text = _score.ToString();
		}

		private void AnimateGodMode()
		{
				var baseColor = _beeSpriteRenderer.color;
				var invisibleColor = new Color(baseColor.r, baseColor.g, baseColor.b, 0);
				var countFlash = 12f;
				var flashTime = GodModeTimeAfterDamage / countFlash;

				var seq = DOTween.Sequence();
				for (int i = 0; i < countFlash; i++)
				{
						seq.Append(_beeSpriteRenderer.DOColor(i % 2 == 0
																				? baseColor
																				: invisibleColor, flashTime));
				}

				seq.OnComplete(() => _beeSpriteRenderer.DOColor(baseColor, 0.1f));
		}
}

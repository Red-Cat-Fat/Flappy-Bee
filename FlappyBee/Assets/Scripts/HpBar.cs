using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HpBar : MonoBehaviour
{
		[SerializeField]
		private GameObject _defaultHealthPointIconPrefab;
		private GameObject[] _healthPointIcons;

		private void TryInitializeHealthPoints(int countHealth)
		{
			if (_healthPointIcons != null && _healthPointIcons.Length < countHealth)
			{
				for (var i = 0; i < _healthPointIcons.Length; i++)
				{
					Destroy(_healthPointIcons[i]);
				}

				_healthPointIcons = null;
			}

			if(_healthPointIcons == null)
			{
				_healthPointIcons = new GameObject[countHealth];
				for (int i = 0; i < countHealth; i++)
				{
					_healthPointIcons[i] = Instantiate(_defaultHealthPointIconPrefab, this.transform);
				}
			}
		}

		public void UpdateHp(int countHealth)
		{
			TryInitializeHealthPoints(countHealth);

			if (countHealth >= 0)
			{
				for (int i = countHealth; i < _healthPointIcons.Length; i++)
				{
					AnimateIconDestroy(_healthPointIcons[i]);
				}
			}
		}

		private void AnimateIconDestroy(GameObject icon)
		{
				var seq = DOTween.Sequence();
				for (int i = 0; i < 7; i++)
				{
						float value = i % 2;
						float time = 1 / (i+2f);
						seq.Append(icon.transform.DOScaleX(value, time));
						seq.Join(icon.transform.DOScaleY(1-value, time));
				}
				seq.OnComplete(() => icon.SetActive(false));
		}
}

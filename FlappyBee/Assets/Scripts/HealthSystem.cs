using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class IntParamEvent : UnityEvent<int>
{

}

public class HealthSystem : MonoBehaviour
{
	[SerializeField]
	private int _hp;
	[SerializeField]
	private SpriteRenderer _beeSpriteRenderer;
	[Tooltip("Время в течении которого пчела будет бессмертна после получения урона")]
	public float GodModeTimeAfterDamage = 0f;
	[SerializeField]
	public IntParamEvent ChangeHp;

	private bool _godMode = false;
	private float _godModeTime = 0f;

	public void Awake()
	{
		ChangeHp?.Invoke(_hp);
	}

	public void GetDamage()
	{
		if(_godMode) return;
		_godMode = true;
		_godModeTime = GodModeTimeAfterDamage;
		_hp--;
		ChangeHp?.Invoke(_hp);

		if(_hp > 0)
		{
			AnimateGodMode();
		}
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

	private void Update()
	{
		if (_godMode)
		{
			_godModeTime -= Time.deltaTime;
			if (_godModeTime < 0)
			{
				_godMode = false;
			}
		}
	}
}

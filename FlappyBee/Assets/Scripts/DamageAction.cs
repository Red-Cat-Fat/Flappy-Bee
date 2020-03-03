using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(HealthSystem))]
public class DamageAction : Action
{
		private bool _godMode = false;
		private float _godModeTime = 0f;
		private HealthSystem _healthSystem;

		private void Awake()
		{
			_healthSystem = gameObject.GetComponent<HealthSystem>();
		}

		protected override void DoExecute(GameObject other)
		{
				if (_godMode) return;
				_healthSystem.GetDamage();
				_godMode = true;
				_godModeTime = _healthSystem.GodModeTimeAfterDamage;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DamageAction : Action
{
		private bool _godMode = false;
		private float _godModeTime = 0f;
		protected override void DoExecute(GameObject other)
		{
				if (_godMode) return;
				var playerData = gameObject.GetComponent<PlayerData>();
				playerData.GetDamage();
				_godMode = true;
				_godModeTime = playerData.GodModeTimeAfterDamage;
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

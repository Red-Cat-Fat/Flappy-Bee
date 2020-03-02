using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScoreAction : Action
{
		[SerializeField]
		private int _score = 1;
		protected override void DoExecute(GameObject other)
		{
				var playerData = other.GetComponentInParent<PlayerData>();
				playerData?.AddScore(_score);
		}
}

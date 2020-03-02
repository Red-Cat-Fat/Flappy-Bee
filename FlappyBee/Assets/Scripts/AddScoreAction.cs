using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScoreAction : Action
{
		protected override void DoExecute(GameObject other)
		{
				var playerData = gameObject.GetComponent<PlayerData>();
				playerData?.AddScore();
		}
}

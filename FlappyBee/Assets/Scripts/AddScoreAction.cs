using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScoreAction : Action
{
		[SerializeField]
		private int _addScore = 1;
		[SerializeField]
		private CounterScriptableObject _scoreCounter;

		protected override void DoExecute(GameObject other)
		{
			_scoreCounter.AddValue(_addScore);
		}
}

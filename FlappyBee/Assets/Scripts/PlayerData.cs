using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{
		[SerializeField]
		private Text _scoreCountText;
		private int _score;

		public void AddScore()
		{
				_score++;
				_scoreCountText.text = _score.ToString();
		}
}

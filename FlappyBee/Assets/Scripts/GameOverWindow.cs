using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverWindow : MonoBehaviour
{
		[SerializeField]
		private Text _scoreText;

		public void Show()
		{
			gameObject.SetActive(true);
		}

		public void SetScore(int score)
		{
				_scoreText.text = $"Total score: {score}";
		}

		public void OnRestartButtonClick()
		{
				SceneManager.LoadScene("Main", LoadSceneMode.Single);
		}
}

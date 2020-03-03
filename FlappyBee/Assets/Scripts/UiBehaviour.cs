using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiBehaviour : MonoBehaviour
{
	[SerializeField] private HpBar _hpBar;
	[SerializeField] private Text _scoreText;
	[SerializeField] private GameOverWindow _gameOverWindow;

	public void UpdateHp(int hp)
	{
		_hpBar?.UpdateHp(hp);
		if (hp <= 0)
		{
			_gameOverWindow.Show();
		}
	}

	public void ChangeScore(int score)
	{
		_scoreText.text = score.ToString();
		_gameOverWindow.SetScore(score);
	}
}

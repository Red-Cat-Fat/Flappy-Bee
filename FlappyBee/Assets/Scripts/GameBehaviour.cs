using UnityEngine;
using UnityEngine.Events;

public class GameBehaviour : MonoBehaviour
{
	private int _score;
	[SerializeField]
	private IntParamEvent _changeScore;

	public void AddScore(int score)
	{
		_score += score;
		_changeScore?.Invoke(_score);
	}
}

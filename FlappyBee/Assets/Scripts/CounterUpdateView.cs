using System;
using UnityEngine;
using UnityEngine.UI;

public class CounterUpdateView : MonoBehaviour
{
	[SerializeField]
	private Text _countText;
	[SerializeField]
	private CounterScriptableObject _counterScriptableObject;

	private void Awake()
	{
		_counterScriptableObject.UpdateScore.AddListener(UpdateCounter);
	}

	private void OnEnable()
	{
		UpdateCounter(_counterScriptableObject.Count);
	}

	private void UpdateCounter(int count)
	{
		_countText.text = count.ToString();
	}
}

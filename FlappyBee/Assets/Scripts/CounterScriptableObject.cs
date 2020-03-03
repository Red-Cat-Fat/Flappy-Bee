using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class CounterScriptableObject : ScriptableObject
{
	[SerializeField]
	private int _count = 0;

	public int Count => _count;
	[SerializeField]
	private bool _resetOnNewGame = true;

	public event Action<int> UpdateScore;
	public void OnEnable()
	{
		if (_resetOnNewGame)
		{
			_count = 0;
		}
	}

	public void AddValue(int count)
	{
		_count += count;
		UpdateScore?.Invoke(_count);
	}

#if UNITY_EDITOR
	[MenuItem("Assets/Create/CounterScriptableObject")]
	public static void CreateMyAsset()
	{
		CounterScriptableObject asset = CreateInstance<CounterScriptableObject>();
		AssetDatabase.CreateAsset(asset, "Assets/Counters/NewCounterScriptableObject.asset");
		AssetDatabase.SaveAssets();
		EditorUtility.FocusProjectWindow();
		Selection.activeObject = asset;
	}
	#endif
}

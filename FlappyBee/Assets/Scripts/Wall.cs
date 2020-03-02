using UnityEngine;

public class Wall : MonoBehaviour
{
	public Transform Up;
	public Transform Down;

	public float From = 1;
	public float To = 2;

	private void OnEnable()
	{
		var t = Random.Range(From, To);
		Up.localPosition += t * Vector3.up;
		Down.localPosition += t * Vector3.down;
	}
}

using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject Prefab;
	public float Interval;

	public float From;
	public float To;

	private float _timer;

	private void FixedUpdate()
	{
		_timer -= Time.fixedDeltaTime;

		if (_timer > 0)
			return;

		_timer += Interval;
		var position = transform.position;
		position.y += Random.Range(From, To);
		Instantiate(Prefab, position, Quaternion.identity);
	}
}

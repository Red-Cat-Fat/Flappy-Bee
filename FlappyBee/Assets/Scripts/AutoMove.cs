using UnityEngine;

public class AutoMove : MonoBehaviour
{
	public Vector2 Speed = new Vector2(1f, 0f);

	private void FixedUpdate()
	{
		transform.localPosition += new Vector3(Speed.x, Speed.y, 0) * Time.deltaTime;
	}
}

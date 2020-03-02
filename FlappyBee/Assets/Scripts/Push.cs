using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Push : MonoBehaviour
{
	public KeyCode KeyCode = KeyCode.Space;

	public Vector2 Force;

	[HideInInspector]
	public Rigidbody2D Rigidbody2D;

	private bool _keyPressed;

	private void OnValidate()
	{
		Rigidbody2D = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		_keyPressed = Input.GetKey(KeyCode);
	}

	private void FixedUpdate()
	{
		if (!_keyPressed)
			return;

		Rigidbody2D.AddForce(Force, ForceMode2D.Impulse);
	}
}

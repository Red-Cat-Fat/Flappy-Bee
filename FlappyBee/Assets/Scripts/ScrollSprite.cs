using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ScrollSprite : MonoBehaviour
{
	public SpriteRenderer Sprite;
	public float Speed;

	private float _distance;

	private float _left;
	private float _right;

	private void OnValidate()
	{
		Sprite = GetComponent<SpriteRenderer>();
	}

	private void OnEnable()
	{
		var spriteBounds = Sprite.bounds;
		var position = transform.position;
		_left = position.x - spriteBounds.extents.x / 3f;
		_right = position.x + spriteBounds.extents.x / 3f;
		_distance = _right - _left;
	}

	private void Update()
	{
		transform.localPosition += Speed * Time.deltaTime * Vector3.right;

		if (Speed > 0 && transform.position.x > _right)
			transform.localPosition -= _distance * Vector3.right;
		else if (Speed < 0 && transform.position.x < _left)
			transform.localPosition -= _distance * Vector3.left;
	}
}

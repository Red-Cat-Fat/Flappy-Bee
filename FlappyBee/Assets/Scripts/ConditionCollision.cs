using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class ConditionCollision : Condition
{
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (string.IsNullOrEmpty(FilterTag) || collision.collider.CompareTag(FilterTag))
			ExecuteAllActions(collision.gameObject);
	}
}

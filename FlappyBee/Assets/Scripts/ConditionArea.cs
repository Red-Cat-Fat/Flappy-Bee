using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class ConditionArea : Condition
{
	public bool OnExit;

	private void OnTriggerEnter2D(Collider2D otherCollider)
	{
		if (OnExit)
			return;

		if (string.IsNullOrEmpty(FilterTag) || otherCollider.CompareTag(FilterTag))
			ExecuteAllActions(otherCollider.gameObject);
	}

	private void OnTriggerExit2D(Collider2D otherCollider)
	{
		if (!OnExit)
			return;

		if (string.IsNullOrEmpty(FilterTag) || otherCollider.CompareTag(FilterTag))
			ExecuteAllActions(otherCollider.gameObject);
	}
}

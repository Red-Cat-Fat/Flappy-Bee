using UnityEngine;

public class DestroyActionBehaviour : ActionBehaviour
{
	public bool DestroyOther;

	protected override void DoExecute(GameObject other)
	{
		if (!DestroyOther)
			Destroy(gameObject);
		else if (other != null)
			Destroy(other);
	}
}

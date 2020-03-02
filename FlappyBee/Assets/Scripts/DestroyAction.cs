using UnityEngine;

public class DestroyAction : Action
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

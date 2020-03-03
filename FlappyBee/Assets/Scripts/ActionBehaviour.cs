using UnityEngine;

public abstract class ActionBehaviour : MonoBehaviour
{
	public bool Once;

	private bool _fired;

	public void Execute(GameObject other)
	{
		if (Once && _fired)
			return;

		_fired = true;

		DoExecute(other);
	}

	protected abstract void DoExecute(GameObject other);
}

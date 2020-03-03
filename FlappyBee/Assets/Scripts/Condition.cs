using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public abstract class Condition : MonoBehaviour
{
	public ActionBehaviour[] Actions = new ActionBehaviour[0];
	public string FilterTag;

	public void ExecuteAllActions(GameObject dataObject)
	{
		foreach (var ga in Actions.Where(ga => ga != null))
			ga.Execute(dataObject);
	}
}

using System.Linq;
using UnityEngine;

public abstract class Condition : MonoBehaviour
{
	public Action[] Actions = new Action[0];

	public string FilterTag;

	public void ExecuteAllActions(GameObject dataObject)
	{
		foreach (var ga in Actions.Where(ga => ga != null))
			ga.Execute(dataObject);
	}
}

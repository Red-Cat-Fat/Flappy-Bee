using UnityEngine;

[RequireComponent(typeof(HealthSystem))]
public class DamageActionBehaviour : ActionBehaviour
{
		private HealthSystem _healthSystem;

		private void Awake()
		{
			_healthSystem = gameObject.GetComponent<HealthSystem>();
		}

		protected override void DoExecute(GameObject other)
		{
				_healthSystem.GetDamage();
		}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void XII_HealthChangeDelegate(float health, float maxHealth);

namespace XII.Components
{
    public class XII_HealthComponent : MonoBehaviour
    {
		public static XII_HealthChangeDelegate OnHealthChanged;

        private XII_HealthData HealthData;
        private void Awake()
        {
            HealthData = GetComponent<XII_StatComponent>().HealthData;
        }

		public void TakeDamage(float amount)
		{
			HealthData.Hp -= amount;

			HealthData.Hp = Mathf.Clamp(HealthData.Hp, 0, HealthData.MaxHp);

			//Debug.Log(HealthData.Hp);

			OnHealthChanged?.Invoke(HealthData.Hp, HealthData.MaxHp);
		}

		public void RecoverDamage(float amount)
		{
			HealthData.Hp += amount;

			HealthData.Hp = Mathf.Clamp(HealthData.Hp, 0, HealthData.MaxHp);

			//Debug.Log(HealthData.Hp);

			OnHealthChanged?.Invoke(HealthData.Hp, HealthData.MaxHp);
		}
	}
}

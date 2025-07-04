using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XII.Data;

public delegate void XII_HealthChangeDelegate(float health, float maxHealth);

namespace XII.Components
{
    public class XII_HealthComponent : MonoBehaviour
    {
        [SerializeField] private XII_HealthData HealthData;

        public XII_HealthChangeDelegate OnHealthChanged;

        private void Awake()
        {
            //HealthData = GetComponent<XII_StatComponent>().HealthData;
        }

        private void Start()
        {
            HealthData.Hp = HealthData.MaxHp;
        }

        public void ReceiveDamage(float amount)
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

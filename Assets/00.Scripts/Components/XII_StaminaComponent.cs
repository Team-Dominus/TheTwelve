using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void XII_StaminaChangeDelegate(float health, float maxHealth);

namespace XII.Components
{
    public class XII_StaminaComponent : MonoBehaviour
    {
		public XII_StaminaChangeDelegate OnStaminaChanged;

		private XII_StaminaData StaminaData;
        private void Awake()
        {
            StaminaData = GetComponent<XII_StatComponent>().StaminaData;
        }

		public void DecreaseStamina(float amount)
		{
			StaminaData.Stamina -= amount;

			StaminaData.Stamina = Mathf.Clamp(StaminaData.Stamina, 0, StaminaData.MaxStamina);

			//Debug.Log(StaminaData.Stamina);

			OnStaminaChanged?.Invoke(StaminaData.Stamina, StaminaData.MaxStamina);
		}

		public void IncreaseStamina(float amount)
		{
			StaminaData.Stamina += amount;

			StaminaData.Stamina = Mathf.Clamp(StaminaData.Stamina, 0, StaminaData.MaxStamina);

			//Debug.Log(StaminaData.Stamina);

			OnStaminaChanged?.Invoke(StaminaData.Stamina, StaminaData.MaxStamina);
		}
	}
}

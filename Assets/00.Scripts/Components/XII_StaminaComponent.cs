using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XII.Data;

public delegate void XII_StaminaChangeDelegate(float stamina, float maxStamina);

namespace XII.Components
{
    public class XII_StaminaComponent : MonoBehaviour
    {
        [SerializeField]
        private XII_StaminaData staminaData;

        public XII_StaminaData StaminaData => staminaData;

        public XII_StaminaChangeDelegate OnStaminaChanged;

        private void Awake()
        {
            //StaminaData = GetComponent<XII_StatComponent>().StaminaData;
        }

		public void DecreaseStamina(float amount)
		{
			staminaData.Stamina -= amount;

			staminaData.Stamina = Mathf.Clamp(staminaData.Stamina, 0, staminaData.MaxStamina);

			//Debug.Log(StaminaData.Stamina);

			OnStaminaChanged?.Invoke(staminaData.Stamina, staminaData.MaxStamina);
		}

		public void IncreaseStamina(float amount)
		{
			staminaData.Stamina += amount;

			staminaData.Stamina = Mathf.Clamp(staminaData.Stamina, 0, staminaData.MaxStamina);

			//Debug.Log(StaminaData.Stamina);

			OnStaminaChanged?.Invoke(staminaData.Stamina, staminaData.MaxStamina);
		}
	}
}

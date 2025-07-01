using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace XII.Components
{
    public class XII_StaminaComponent : MonoBehaviour
    {
        private XII_StaminaData StaminaData;
        private void Awake()
        {
            StaminaData = GetComponent<XII_StatComponent>().StaminaData;
        }
    }
}

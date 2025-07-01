using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace XII.Components
{
    public class XII_HealthComponent : MonoBehaviour
    {
        private XII_HealthData HealthData;
        private void Awake()
        {
            HealthData = GetComponent<XII_StatComponent>().HealthData;
        }
    }
}

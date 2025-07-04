using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace XII.Data
{
    [CreateAssetMenu(fileName = "CharacterData", menuName = "Object/Character/StaminaData", order = int.MaxValue)]
    public class XII_StaminaData : ScriptableObject
    {
        public float MaxStamina;
        public float Stamina;
    }
}


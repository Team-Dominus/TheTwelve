using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace XII.Data
{
    [CreateAssetMenu(fileName = "CharacterData", menuName = "Object/Character/CombatData", order = int.MaxValue)]
    public class XII_CombatData : ScriptableObject
    {
        public float Atk;
        public float AtkSpeed;
    }
}


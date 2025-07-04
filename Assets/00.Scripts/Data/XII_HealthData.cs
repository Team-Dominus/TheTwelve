using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace XII.Data
{
    [CreateAssetMenu(fileName = "CharacterData", menuName = "Object/Character/HealthData", order = int.MaxValue)]
    public class XII_HealthData : ScriptableObject
    {
        public float MaxHp;
        public float Hp;
        public float Def;
    }
}


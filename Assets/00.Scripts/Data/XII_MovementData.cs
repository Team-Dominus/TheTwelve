using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace XII.Data
{
    [CreateAssetMenu(fileName = "CharacterData", menuName = "Object/Character/MovementData", order = int.MaxValue)]
    public class XII_MovementData : ScriptableObject
    {
        public float MoveSpeed;

        public float JumpPower;

        public float DashPower;
        public float DashDistance;
    }
}

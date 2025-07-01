using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XII.Components;


// 링크 / 담당자

namespace XII.Characters
{
    // Unity Components
    [RequireComponent(typeof(Rigidbody2D))]

    // Custom Components
    [RequireComponent(typeof(XII_StatComponent))]
    [RequireComponent(typeof(XII_MovementComponent))]
    [RequireComponent(typeof(XII_StateComponent))]
    [RequireComponent(typeof(XII_HealthComponent))]
    [RequireComponent(typeof(XII_StaminaComponent))]
    [RequireComponent(typeof(XII_SkillComponent))]
    [RequireComponent(typeof(XII_CombatComponent))]

    public class XII_BaseCharacter : MonoBehaviour
    {
        protected Vector2 Direction;
        protected XII_MovementComponent MovementComponent;
        
        protected virtual void Awake()
        {
            MovementComponent = GetComponent<XII_MovementComponent>();
        }
    }
}



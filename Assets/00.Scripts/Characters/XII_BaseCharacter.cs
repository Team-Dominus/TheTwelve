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
        protected XII_HealthComponent HealthComponent;
        protected XII_StaminaComponent StaminaComponent;
        protected XII_StateComponent StateComponent; // Add a reference to XII_StateComponent

        protected virtual void Awake()
        {
            MovementComponent = GetComponent<XII_MovementComponent>();
            HealthComponent = GetComponent<XII_HealthComponent>();
            StaminaComponent = GetComponent<XII_StaminaComponent>();
            StateComponent = GetComponent<XII_StateComponent>(); // Initialize the StateComponent
        }

        protected virtual void Start()
        {
            if (HealthComponent != null)
                HealthComponent.OnHealthChanged += OnHealthChanged;

            if (StaminaComponent != null)
                StaminaComponent.OnStaminaChanged += OnStaminaChanged;

            if (StateComponent != null)
                StateComponent.OnStateChanged += OnStateChanged; // Use the instance of StateComponent
        }

        protected virtual void OnHealthChanged(float health, float maxHealth)
        {
        }

        protected virtual void OnStaminaChanged(float stamina, float maxStamina)
        {
        }

        protected virtual void OnStateChanged(EState state)
        {
            // Override this method in derived classes to handle state changes
        }
    }
}



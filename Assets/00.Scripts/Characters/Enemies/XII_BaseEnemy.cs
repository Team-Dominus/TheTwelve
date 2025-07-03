using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XII.Characters;

namespace XII.Characters
{

    // Unity Components

    [RequireComponent(typeof(CapsuleCollider2D))] // Test

    // Custom Components

    public class BaseEnemy : XII_BaseCharacter
    {
        protected override void Awake()
        {
            base.Awake();
        }

        protected override void Start()
        {
            base.Start();
        }

        protected override void OnHealthChanged(float health, float maxHealth)
        {
            //여기에 UI 연결하면 될듯함
            Debug.Log("BaseEnemy - " + health / maxHealth);
        }

        protected override void OnStaminaChanged(float stamina, float maxStamina)
        {
            //여기에 UI 연결하면 될듯함
            Debug.Log("BaseEnemy - " + stamina / maxStamina);
        }
    }
    


}

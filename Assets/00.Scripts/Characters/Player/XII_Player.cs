using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

using XII.Components;

namespace XII.Characters
{
    // Unity Components
    [RequireComponent(typeof(PlayerInput))]
    [RequireComponent(typeof(CapsuleCollider2D))]

    // Custom Components

    public class XII_Player : XII_BaseCharacter
    {

        protected override void Awake()
        {
            base.Awake();

            InputSettings();
        }

        private void Update()
        {
            MovementComponent.Move(Direction);
        }

        private void InputSettings()
        {
            PlayerInput input = GetComponent<PlayerInput>();
            InputActionMap actionMap = input.actions.FindActionMap("Player");
            
            InputAction movementAction = actionMap.FindAction("Movement");
            if (movementAction != null)
            {
                movementAction.performed += ctx => { Direction = ctx.ReadValue<Vector2>(); };
                movementAction.canceled += ctx  => { Direction = Vector2.zero; };
            }

            InputAction jumpAction = actionMap.FindAction("Jump");
            if (jumpAction != null)
            {
                jumpAction.started += ctx => { MovementComponent.Jump(); };
            }

            InputAction dashAction = actionMap.FindAction("Dash");
            if (dashAction != null)
            {
                dashAction.started += ctx => { MovementComponent.Dash(); };
            }
        }
    }
}


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

		protected override void Start()
		{
			base.Start();
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

            InputAction attackAction = actionMap.FindAction("Attack");
            if (attackAction != null)
            {
                attackAction.started += ctx => { BaseAttackComponent.Attack(); };
            }

            //����� - ü�� ȸ�� / ���¹̳� ����
            InputAction debugPlus = actionMap.FindAction("DebugPlus");
			if (debugPlus != null)
			{
				debugPlus.started += ctx => { StaminaComponent.IncreaseStamina(10); };
				//debugPlus.started += ctx => { HealthComponent.RecoverDamage(10); };
			}

			//����� - ü�� ���� / ���¹̳� ����
			InputAction debugMinus = actionMap.FindAction("DebugMinus");
			if (debugMinus != null)
			{
				debugMinus.started += ctx => { StaminaComponent.DecreaseStamina(10); };
				//debugMinus.started += ctx => { HealthComponent.TakeDamage(10); };
			}

            //����� - State ����
            InputAction debugState = actionMap.FindAction("DebugState");
            if(debugState != null)
            {
                debugState.started += ctx => { StateComponent.StateChanged(EState.Die); };

                //Send State : Boss.StateComponent.StateChanged(EState.Hit); ->
            }
        }

		protected override void OnHealthChanged(float health, float maxHealth)
		{
			//���⿡ UI �����ϸ� �ɵ���
			Debug.Log(health / maxHealth);
		}

		protected override void OnStaminaChanged(float stamina, float maxStamina)
		{
			//���⿡ UI �����ϸ� �ɵ���
			Debug.Log(stamina / maxStamina);
		}

    }
}


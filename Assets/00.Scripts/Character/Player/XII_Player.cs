using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace XII.Characters
{
    // Unity Components
    [RequireComponent(typeof(PlayerInput))]

    // Custom Components




    public class XII_Player : XII_BaseCharacter
    {
        [Header("##Setting")]
        [SerializeField] private float moveSpeed = 5f;

        private Vector2 Direction;

        public void Awake()
        {
            PlayerInput input = GetComponent<PlayerInput>();
            InputActionMap actionMap = input.actions.FindActionMap("Player");

            if (actionMap != null)
            {
                InputAction movementAction = actionMap.FindAction("Movement");
                if (movementAction != null)
                {
                    movementAction.performed += ctx => { Direction = ctx.ReadValue<Vector2>(); };
                    movementAction.canceled += ctx => { Direction = Vector2.zero; };
                }
            }
        }

        private void Update()
        {
            Move();
        }

        void Move()
        {
            transform.Translate(Direction.x * Time.deltaTime * moveSpeed, Direction.y * Time.deltaTime * moveSpeed, 0.0f);
        }


    }

}


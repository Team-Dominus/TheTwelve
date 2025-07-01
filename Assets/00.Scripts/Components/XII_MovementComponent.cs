using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using XII.Characters;


namespace XII.Components
{
    public class XII_MovementComponent : MonoBehaviour
    {
        [Header("##Setting")]
        [SerializeField] XII_MovementeData MovementData;

        Rigidbody2D Rigidbody;

        private void Awake()
        {
            Rigidbody = GetComponent<Rigidbody2D>();
        }

        public void Move(Vector2 direction)
        {
            transform.Translate(direction * MovementData.MoveSpeed * Time.deltaTime, Space.World);
        }

        public void Jump()
        {
            Rigidbody.AddForce(Vector2.up * MovementData.JumpPower, ForceMode2D.Impulse);
        }
    }
}


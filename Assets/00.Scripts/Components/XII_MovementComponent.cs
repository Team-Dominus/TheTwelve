using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
            Rigidbody.MovePosition(Rigidbody.position + direction * MovementData.MoveSpeed * Time.deltaTime); 
        }

        public void Jump()
        {
            //Vector2 YVelocity = new Vector2(0.0f, transform.position.y);
            //Rigidbody.AddForce(YVelocity *MovementData.JumpPower, ForceMode2D.Impulse);
            Rigidbody.AddForce(Vector2.up * MovementData.JumpPower, ForceMode2D.Impulse);
        }
    }
}


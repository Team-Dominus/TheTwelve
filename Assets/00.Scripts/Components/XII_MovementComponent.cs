using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEditor.Rendering;
using UnityEngine;
using XII.Characters;
using XII.Data;

namespace XII.Components
{
    public class XII_MovementComponent : MonoBehaviour
    {
        [SerializeField]
        private XII_MovementData MovementData;

        private Vector2 DashDirection = Vector2.right;
        private bool bDashing = false;

        private Rigidbody2D Rigidbody;

        private void Awake()
        {
            Rigidbody    = GetComponent<Rigidbody2D>();
            //MovementData = GetComponent<XII_StatComponent>().MovementData;
        }

        public void Move(Vector2 direction)
        {
            if (bDashing) return;

            if (direction.sqrMagnitude >= 0.01)
            {
                DashDirection = direction;
            }
            transform.Translate(direction * MovementData.MoveSpeed * Time.deltaTime, Space.World);
        }

        public void Jump()
        {
            Rigidbody.AddForce(Vector2.up * MovementData.JumpPower, ForceMode2D.Impulse);
        }

        public void Dash()
        {
            if (bDashing) return;

            StartCoroutine(DashCoroutine(transform.position));
        }

        IEnumerator DashCoroutine(Vector2 position)
        {
            bDashing = true;
            Rigidbody.velocity = Vector2.zero;
            Rigidbody.AddForce(DashDirection * MovementData.DashPower, ForceMode2D.Impulse);
            Rigidbody.gravityScale = 0f;


            while (Vector2.Distance(transform.position, position) < MovementData.DashDistance)
            {
                yield return null; 
            }


            Rigidbody.gravityScale = 1f;
            Rigidbody.velocity = Vector2.zero;
            bDashing = false;
        }
    }
}


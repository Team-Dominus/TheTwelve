using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XII.Components;


// 링크 / 담당자

namespace XII.Characters
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(XII_MovementComponent))]

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



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XII_Player : XII_BaseCharacter
{
    [Header("##Setting")]
    [SerializeField] private float moveSpeed = 5.0f; // 플레이어 이동 속도




    private Rigidbody2D Rigidbody;

    private void Start()
    {
        // Rigidbody2D 컴포넌트 초기화
        Rigidbody = GetComponent<Rigidbody2D>();
        if (Rigidbody == null)
        {
            Debug.LogError("Rigidbody2D component not found on the player object.");
        }
        else
        {
            Debug.Log("Rigidbody2D component initialized successfully.");
        }
        
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        

        // 플레이어 점프
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 점프
            Debug.Log("Space key pressed");
        }

        // 플레이어 이동
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(moveHorizontal, moveVertical, 0.0f);

        if (Rigidbody != null)
        {
            //Rigidbody.velocity = movement * 5.0f; // 속도 조절
            Rigidbody.MovePosition(transform.position + direction * Time.deltaTime * moveSpeed);
        }
    }
}

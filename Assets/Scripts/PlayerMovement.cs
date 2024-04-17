using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jmp = 10;
    private Rigidbody2D rb;
    public const float speed = 5f;
    public const float Run = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
     
        if (Input.GetKey(KeyCode.A))
        {           
            Debug.Log("A");
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Debug.Log("Shift");
                rb.velocity = new Vector2(-Run, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(-speed, rb.velocity.y);
            }
        }
        else if (Input.GetKey(KeyCode.D)) {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Debug.Log("Shift");
                rb.velocity = new Vector2(Run, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(speed, rb.velocity.y);
            }
            Debug.Log("D");
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.velocity = new Vector2(rb.velocity.x, jmp);
            Debug.Log("Space");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 4f;
    public float jumpForce = 8f;
    public Rigidbody2D rb;

    private Vector2 playerInput;

    private void Awake()
    {
        
    }

    private void Update()
    {
        playerInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Verticle"));
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(playerInput.x * moveSpeed, rb.velocity.y);
    }

    private void Jump()
    {
        rb.AddForce(new Vector2(0, jumpForce));
    }
}

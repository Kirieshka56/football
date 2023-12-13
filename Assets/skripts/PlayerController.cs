using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float  speed;
    public float jumpForce;
    private Rigidbody2D rb;
    private float moveInput;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        moveInput = Input.GetAxis("Jump");
        rb.velocity = new Vector3(moveInput * jumpForce, moveInput * speed);
    }
}

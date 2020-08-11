using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    Rigidbody2D rb;
    AudioSource effect;
    public float horizontalSpeed = 5;
    public float horizontalMove;
    public float radius = 0.1F;
    public float jumpForce = 5;

    public LayerMask myLayer;
    public Transform myObj;

    bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        effect = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        Move();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(myObj.position, radius, myLayer);

        if (isGrounded)
        {
            Vector2 force = new Vector2(0, jumpForce);
            effect.Play();
            rb.velocity = force;
        }
    }

    void Move()
    {
        horizontalMove = Input.GetAxis("Horizontal") * horizontalSpeed;
        Vector2 force = new Vector2(horizontalMove, rb.velocity.y);
        rb.velocity = force;
    }
}

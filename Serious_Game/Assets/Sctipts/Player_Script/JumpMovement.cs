using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMovement : MonoBehaviour
{

    public float moveSpeed;
    float xInput, yInput;

    Rigidbody2D rb;
    SpriteRenderer sp;

    public float jumpForce;

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        transform.Translate(xInput * moveSpeed, yInput * moveSpeed, 0);

        PlatformerMove();
        FlipPlayer();
    }

    void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }

    void PlatformerMove()
    {
        rb.velocity = new Vector2(moveSpeed * xInput, rb.velocity.y);
    }

    void FlipPlayer()
    {
        if(rb.velocity.x < -0.1f)
        {
            sp.flipX = true;
        }

        else if (rb.velocity.x > 0.1f)
        {
            sp.flipX = false;
        }
    }
    
}

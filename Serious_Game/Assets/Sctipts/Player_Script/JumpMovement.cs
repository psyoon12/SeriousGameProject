using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpMovement : MonoBehaviour
{

    public float moveSpeed;
    float xInput, yInput;
    public Animator animator;

    Rigidbody2D rb;
    SpriteRenderer sp;
    Vector2 movement;

    public float jumpForce;

    [SerializeField] GameObject AI;

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        AI = AI = GameObject.FindWithTag("AI");
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

        animator.SetFloat("Horizontal", xInput);
        animator.SetFloat("Vertical", yInput);

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
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Collectable"))
        {
            Destroy(other.gameObject);
            AI = GameObject.FindWithTag("AI");
            AI.SetActive(false);
        }

        if (other.gameObject.CompareTag("BottomBoundary")){
            SceneManager.LoadScene("Town");
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        AI.SetActive(true);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    const float speed = 10f;
    const float jumpVelocity = 10f;
    Rigidbody2D rb;
    float inputX;
    bool hasDoubleJump;
    bool isGrounded;

    [SerializeField] LayerMask groundLayers;
    [SerializeField] Transform groundCheckTrans;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = GroundCheck();
        inputX = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(inputX * speed, rb.velocity.y);

        if (isGrounded)
        {
            hasDoubleJump = true;
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (isGrounded)
            {
                Jump();
            }
            else if (hasDoubleJump)
            {
                Jump();
                hasDoubleJump = false;
            }

        }

    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpVelocity);
    }

    bool GroundCheck()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheckTrans.position, 0.1f, groundLayers);

        if (colliders.Length > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
     public Vector3 frontCheck;
    public Vector3 centerCheck;
    public Vector3 backCheck;
    public float jumpForce = 10;
    private Rigidbody2D rb;
    public Animator animator;
    private bool canJump = true;
    void Start()
    {
        //grabs the rigidbody component
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            canJump = true;
        }
        animator.SetInteger("velocity",(int)rb.velocity.y);
    }
    void FixedUpdate()
    {
        if (canJump)
        {
            canJump = false;
            RaycastHit2D hit1 = Physics2D.Raycast(transform.position + frontCheck, -Vector2.up, 0.1f);
            RaycastHit2D hit2 = Physics2D.Raycast(transform.position + centerCheck, -Vector2.up, 0.1f);
            RaycastHit2D hit3 = Physics2D.Raycast(transform.position + backCheck, -Vector2.up, 0.1f);

            Debug.Log(hit1.collider);
            Debug.Log(hit2.collider);
            Debug.Log(hit3.collider);
            if (hit1.collider != null || hit2.collider != null || hit3.collider != null)
            {
                rb.AddForce(Vector2.up * jumpForce);
            }
        }
    }
}

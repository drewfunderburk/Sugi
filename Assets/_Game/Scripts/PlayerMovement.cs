using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float acceleration
     = 10;
    public float maxSpeed = 40;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float input = Input.GetAxisRaw("Horizontal");
        
        Vector2 movement = new Vector2(input * acceleration,rb.velocity.y);
        rb.AddForce(movement);
        float clampedX = Mathf.Clamp(rb.velocity.x,-maxSpeed,maxSpeed);
        rb.velocity = new Vector2(clampedX, rb.velocity.y);
    }
}

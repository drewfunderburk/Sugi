using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public Vector3 frontCheck;
    public Vector3 backCheck;
    public float acceleration = 10;
    Rigidbody2D rb;
    Vector2 force = Vector2.right;
    // Start is called before the first frame update
    void Start()
    {   
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit2D hit1 = Physics2D.Raycast(transform.position + frontCheck,Vector2.right,0.1f);
        RaycastHit2D hit2 = Physics2D.Raycast(transform.position + backCheck,Vector2.left,0.1f);
        
        if(hit1.collider != null || hit2.collider != null)
            force *= -1;

        Debug.Log(hit1.collider);
        Debug.Log(hit2.collider);
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        rb.AddForce(force * acceleration);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullBody : MonoBehaviour
{
    Rigidbody2D rb;
    Collider2D collide;
    Collider2D child;
    public GameObject connect;
    public Animator animator;
    public Animator headAnimator;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collide = GetComponent<Collider2D>();
        child = connect.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetInteger("velocity", (int)rb.velocity.x);

        if(connect.GetComponent<PlayerStat>().gold)
        {
            if(collide.IsTouching(child))
            {
                connect.GetComponent<Collider2D>().enabled = false;
                connect.GetComponent<Rigidbody2D>().isKinematic = true;
                connect.GetComponent<PlayerMovement>().enabled = false;

                connect.transform.SetParent(transform);
                if(rb.velocity.x > 0)
                    connect.transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y + 1.9f,transform.position.z);
                else if(rb.velocity.x < 0)
                    connect.transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y + 1.9f,transform.position.z);

                connect.transform.rotation = new Quaternion();
                headAnimator.SetBool("isOnBody",true);
            }
        }
    }
}

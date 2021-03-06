using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
     public Transform frontCheck;
    public Transform centerCheck;
    public Transform backCheck;
    public float jumpForce = 10;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxisRaw("Jump") == 0)
            return;

        RaycastHit2D hit1 = Physics2D.Raycast(frontCheck.position, -Vector2.up,1);
        RaycastHit2D hit2 = Physics2D.Raycast(centerCheck.position, -Vector2.up,1);
        RaycastHit2D hit3 = Physics2D.Raycast(backCheck.position, -Vector2.up,1);

        if(hit1.collider != null || hit2.collider != null || hit3.collider != null)
            rb.AddForce(Vector2.up * jumpForce);
        Debug.Log(hit1.collider);
        Debug.Log(hit2.collider);
        Debug.Log(hit3.collider);
    }
}

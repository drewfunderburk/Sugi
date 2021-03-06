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
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Jump") == 0)
            return;

        RaycastHit2D hit1 = Physics2D.Raycast(transform.position + frontCheck, -Vector2.up, 0.1f);
        RaycastHit2D hit2 = Physics2D.Raycast(transform.position + centerCheck, -Vector2.up, 0.1f);
        RaycastHit2D hit3 = Physics2D.Raycast(transform.position + backCheck, -Vector2.up, 0.1f);

        if (hit1.collider != null || hit2.collider != null || hit3.collider != null)
            rb.AddForce(Vector2.up * jumpForce);
    }
}

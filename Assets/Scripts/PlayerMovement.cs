using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    public float jumpForce;
    public int maxJumps;
    float shift;
    int hasJump;
    Rigidbody rb;
    public AudioManager Am;

    // Start is called before the first frame update
    void Start()
    {
        shift = (movementSpeed * 2);
        hasJump = maxJumps;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space) && hasJump > 0)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJump--;
            Am.PlayClip2();
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W) && hasJump == maxJumps)
        {
            transform.Translate(0, 0, shift);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            hasJump = maxJumps;
        }
    }
}

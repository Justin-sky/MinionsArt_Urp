using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody rb;
    private Vector3 moveDirection;
    private float moveSpeed = 4f;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        }
        else
        {
            moveDirection = Vector3.zero;
        }

        if (moveDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(moveDirection), 0.15F);
            moveDirection = new Vector3(moveDirection.x * moveSpeed, Mathf.Clamp(rb.velocity.y, -5, 5), moveDirection.z * moveSpeed);
            rb.velocity = moveDirection;
        }
        else
        {
            rb.velocity = new Vector3(moveDirection.x, Mathf.Clamp(rb.velocity.y, -5, 5), moveDirection.z);
        }

    }
}

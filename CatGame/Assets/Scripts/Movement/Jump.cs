using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float jumpPower = 10f;
    [SerializeField] private float gravityScale = 5;
    [SerializeField] private bool isGround;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.AddForce(Physics.gravity * (gravityScale - 1) * rb.mass);
    }

    private void OnJump() 
    {
        if (!isGround) 
        {
            rb.AddForce(transform.up * jumpPower);
            isGround = true;
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Ground")
            isGround = false;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingBall : MonoBehaviour
{
    public float jumpForce = 5f;
    public float period = 0.5f;

    private Rigidbody rb;
    private float initialHeight;
    private bool isJumping;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialHeight = transform.position.y;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            Jump();
        }
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isJumping = true;
        Invoke("StopJump", period);
    }

    private void StopJump()
    {
        isJumping = false;
    }

    private void FixedUpdate()
    {
        if (isJumping)
        {
            float currentHeight = transform.position.y;
            float jumpHeight = currentHeight - initialHeight;
            Debug.Log("Jump height: " + jumpHeight);
        }
    }
}


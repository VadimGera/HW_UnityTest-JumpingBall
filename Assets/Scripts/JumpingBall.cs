using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingBall : MonoBehaviour
{
    private Rigidbody rb;
    private float initialHeight;
    private bool isJumping;
    private float jumpStartTime;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialHeight = transform.position.y;
        isJumping = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            Jump();
        }

        if (isJumping && Time.time - jumpStartTime >= 0.5f)
        {
            isJumping = false;
            float currentHeight = transform.position.y;
            float jumpHeight = currentHeight - initialHeight;
            Debug.Log("Jump height: " + jumpHeight);
        }
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
        isJumping = true;
        jumpStartTime = Time.time;
    }
}


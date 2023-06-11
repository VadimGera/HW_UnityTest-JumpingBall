using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class JumpingBall : MonoBehaviour
{
    public Rigidbody rb;
    public float initialHeight;
    public float jumpHeight;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialHeight = transform.position.y;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * 14f, ForceMode.Impulse);
        Invoke("MeasureHeight", 0.5f);
    }

    public void MeasureHeight()
    {
        jumpHeight = transform.position.y - initialHeight;
        Debug.Log("Jump height at 0.5s: " + jumpHeight);
    }
}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class JumpingBall : MonoBehaviour
{
    private Rigidbody rb;
    private float initialHeight;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialHeight = transform.position.y;
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
    }

    private void Update()
    {
        // Если прошло 0.5 секунды после прыжка, проверяем высоту
        if (Time.time - initialHeight > 0.5f)
        {
            float currentHeight = transform.position.y;
            float jumpHeight = currentHeight - initialHeight;

            Debug.Log("Jump Height: " + jumpHeight);
        }
    }
}



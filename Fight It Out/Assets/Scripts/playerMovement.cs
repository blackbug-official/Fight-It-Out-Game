using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody player;

    [SerializeField] int forwardForce = 1000;
    [SerializeField] float rotationFactor = 100f;

    // Update is called once per frame
    void Update()
    {
        ForwardAndBackwardMovement();

        SidewaysRotation();

    }

    private void SidewaysRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.Rotate(Vector3.down * Time.deltaTime * rotationFactor);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.Rotate(Vector3.up * Time.deltaTime * rotationFactor);
        }
    }

    private void ForwardAndBackwardMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            player.AddRelativeForce(0, 0, forwardForce * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.AddRelativeForce(0, 0, -forwardForce * Time.deltaTime);
        }
    }
}

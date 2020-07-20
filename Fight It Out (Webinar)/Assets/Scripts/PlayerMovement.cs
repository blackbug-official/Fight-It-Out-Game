using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody Player;
    public float ForwardForce;
    public float RotationForce;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Player.AddRelativeForce(0f, 0f, ForwardForce * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Player.AddRelativeForce(0f, 0f, -ForwardForce * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Player.transform.Rotate(0f, RotationForce * Time.deltaTime , 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Player.transform.Rotate(0f, -RotationForce * Time.deltaTime, 0f);
        }
    }
}

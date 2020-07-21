using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFiring : MonoBehaviour
{
    [SerializeField] ParticleSystem Bullets;

    // Update is called once per frame
    void LateUpdate()
    {
        ControlFiring();
    }

    private void ControlFiring()
    {
        var emissionModule = Bullets.emission;
        if (Input.GetMouseButton(0))
        {
           // print("button down");
            emissionModule.enabled = true;
        }
        else
        {
            //print("button up");
            emissionModule.enabled = false;
        }
    }
}

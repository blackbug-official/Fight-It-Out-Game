using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFiring : MonoBehaviour
{
    public ParticleSystem Bullets;

    // Update is called once per frame
    void Update()
    {
        var EmissionModule = Bullets.emission;
        if (Input.GetMouseButton(0))
        {
            EmissionModule.enabled = true;
        }
        else
        {
            EmissionModule.enabled = false;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFiring : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] float shootingRange = 5f;

    [SerializeField] ParticleSystem EnemyBullets;

    // Update is called once per frame
    void Update()
    {
        ControlEnemyFiring();
    }

    private void ControlEnemyFiring()
    {
        var emissionModule = EnemyBullets.emission;
        float distFromPlayer = Vector3.Distance(this.transform.position, Player.transform.position);

        if(distFromPlayer <= shootingRange)
        {
            this.transform.LookAt(Player);
            emissionModule.enabled = true;
        }
        else
        {
            emissionModule.enabled = false;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFiring : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] Rigidbody Enemy;
    [SerializeField] ParticleSystem EnemyBullets;

    [SerializeField] float shootingRange = 5f;
    [SerializeField] float EnemyMovementForce = 100f;


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
            //Enemy.AddRelativeForce(Vector3.right * EnemyMovementForce * Time.deltaTime);

            emissionModule.enabled = true;
        }
        else
        {
            emissionModule.enabled = false;
        }
    }
}

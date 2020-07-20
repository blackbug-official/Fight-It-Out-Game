using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public ParticleSystem DeathFx;

    private void OnParticleCollision(GameObject other)
    {
        Instantiate(DeathFx, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}

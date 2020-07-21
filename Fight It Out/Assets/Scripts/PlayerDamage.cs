using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField] ParticleSystem DeathFXPrefab;
    [SerializeField] int health = 5;

    private void OnParticleCollision(GameObject other)
    {
        if(other.CompareTag("Enemy Bullets"))
        {
            health = health - 1;
            DeathCheck();
        }

    }

    private void DeathCheck()
    {
        if (health <= 0)
        {
            Instantiate(DeathFXPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }


    }
}

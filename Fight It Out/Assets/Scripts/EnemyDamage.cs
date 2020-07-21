using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] ParticleSystem DeathFXPrefab;
    [SerializeField] int health = 3;

    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Player Bullets"))
        {
            health = health - 1;
            DeathCheck();
        }

    }

    private void DeathCheck()
    {
        if(health <=0)
        {
            Instantiate(DeathFXPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        
    }
}

﻿using UnityEngine;


public class Target : MonoBehaviour
{
    public float health = 50f;

    public void Takedam(float cant)
    {
        health -= cant;
        if(health <=0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        PlayerManager.Killcount++;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bate"))
        {
            health -= 50f;
        }
        if(other.CompareTag("Tower"))
        {
            Die();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Tower"))
        {
            Die();
        }
    }
}

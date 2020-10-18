using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPoolSpawner : MonoBehaviour
{
    public float t;
    EnemyPooler enemypooler;

    void Start()
    {
        t = 7;
        enemypooler = EnemyPooler.Instance;
    }

    void Update()
    {
        t -= Time.deltaTime;

        if (t <= 0)
        {
            Spawnene();
            t = 7;
        }
    }

    private void Spawnene()
    {
        enemypooler.Spawn("Ene", transform.position, Quaternion.identity);
        Debug.Log("el pool esta mal");
    }
}

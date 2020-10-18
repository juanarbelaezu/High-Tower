using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPoolJug : MonoBehaviour
{
    public float t;
    EnemyPooler enemypooler;

    void Start()
    {
        t = 15;
        enemypooler = EnemyPooler.Instance;
    }

    void Update()
    {
        t -= Time.deltaTime;

        if (t <= 0)
        {
            Spawnene();
            t = 15;
        }
    }

    private void Spawnene()
    {
        enemypooler.Spawn("Jug", transform.position, Quaternion.identity);
        Debug.Log("el pool esta mal");
    }
}

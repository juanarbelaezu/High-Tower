using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject enemy;
    private float t;
    [SerializeField] int counter;


    // Start is called before the first frame update
    void Start()
    {
        t = 7f;
    }

    // Update is called once per frame
    void Update()
    {
        if(counter > 0)
        {
            if (t <= 0)
            {
                spawn();
                t = 7;
            }
            if (t > 0)
            {
                t -= Time.deltaTime;
            }
        }
    }

    void spawn()
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
        t = 7;
        counter -= 1;
    }

}

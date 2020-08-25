using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    [SerializeField] GameObject spawner;
    private Transform target;
    public GameObject proyectil;
    private float t;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Tower").GetComponent<Transform>();
        t = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        t -= Time.deltaTime;

        if (t <= 0)
        {
            Fire();
        }

        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookrotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookrotation, Time.deltaTime * 5f);
    }

    void Fire()
    {
        GameObject spawner = Instantiate(proyectil, transform.position, Quaternion.identity) as GameObject;
        spawner.GetComponent<Rigidbody>().AddForce(transform.forward * 2000);
        t = 5;
    }
        
}

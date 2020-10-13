using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    //[SerializeField] GameObject spawner;
    [SerializeField] Transform spawner;
    private Transform target;
    public GameObject proyectil;
    private float t;
    ShootCommand comando;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Tower").GetComponent<Transform>();
        comando = new ShootCommand(spawner, proyectil);
        t = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        t -= Time.deltaTime;

        if (t <= 0)
        {
            /*Fire();*/
            comando.Execute();
            t = 15f;
        }

        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookrotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookrotation, Time.deltaTime * 5f);
    }

    /*void Fire()
    {
        GameObject spawner = Instantiate(proyectil, transform.position, Quaternion.identity) as GameObject;
        spawner.GetComponent<Rigidbody>().AddForce(transform.forward * 2000);
        t = 5;
    }*/
        
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCommand : ICommand
{
    protected Transform spawnLocation;
    protected Transform target;
    protected GameObject bullet;

    public ShootCommand(Transform spawnLocation, GameObject bullet, Transform target)
    {
        this.spawnLocation = spawnLocation;
        this.target = target;
        this.bullet = bullet;
    }

    public void Execute()
    {
        /*GameObject spawner = Instantiate(proyectil, transform.position, Quaternion.identity) as GameObject;
        spawner.GetComponent<Rigidbody>().AddForce(transform.forward * 2000);*/
    }
}

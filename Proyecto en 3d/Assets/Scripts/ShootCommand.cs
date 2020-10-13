using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCommand : ICommand
{
    protected Transform spawnLocation;
    protected GameObject bullet;

    public ShootCommand(Transform spawnLocation, GameObject bullet)
    {
        this.spawnLocation = spawnLocation;
        this.bullet = bullet;
    }

    public void Execute()
    {
        GameObject spawner = GameObject.Instantiate(bullet, spawnLocation.position, Quaternion.identity) as GameObject;
        spawner.GetComponent<Rigidbody>().AddForce(spawnLocation.forward * 3000);
    }
}

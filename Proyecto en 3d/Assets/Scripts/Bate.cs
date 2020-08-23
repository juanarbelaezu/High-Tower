using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bate : MonoBehaviour
{
    public float damage = 50f;
    public float range = 1f;
    public float force = 15f;
    public float firerate = 1f;

    public Camera fpscam;

    private float nextfire = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextfire)
        {
            nextfire = Time.time + 1f / firerate;
            Shoot();
        }

        void Shoot()
        {
            //flash.Play();
            RaycastHit hit;
            if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range))
            {
                Debug.Log(hit.transform.name);
                Target target = hit.transform.GetComponent<Target>();
                if (target != null)
                {
                    target.Takedam(damage);
                }

                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(-hit.normal * force);
                }
            }
        }
    }
}

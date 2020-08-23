using UnityEngine;

public class Pistol : MonoBehaviour
{

    public float damage = 20f;
    public float range = 50f;
    public float force = 15f;
    public float firerate = 1f;

    public Camera fpscam;

    public ParticleSystem flash;
    public GameObject impact;

    private float nextfire = 0f;

    public AudioClip disparo1;

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
            flash.Play();
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

                GameObject imgo = Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(imgo, 2f);
            }
            ManagerSonido.instance.Randomize(disparo1);
        }
    }
}

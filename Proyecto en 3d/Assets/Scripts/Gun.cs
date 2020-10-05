using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Gun : MonoBehaviour
{

    public float damage = 50f;
    public float range = 150f;
    public float force = 30f;
    public float firerate = 15f;

    public Camera fpscam;

    public int maxAmmo = 30;
    private int currentAmmo;
    private float reloadtime = 3f;
    private bool itsReload = false;

    public ParticleSystem flash;
    public GameObject impact;

    private float nextfire = 0f;

    public Text ammomag;

    Animator anim;

    public AudioClip disparo;
    public AudioClip ini;
    public AudioClip fin;

    private void Start()
    {
       anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (itsReload)
        {
            return;
        }

        if (Input.GetButton("Fire1") && Time.time >= nextfire)
        {
            if(Ammo.rifleammo > 0)
            { 
            nextfire = Time.time + 1f / firerate;
            Shoot();
            }
            else if (Ammo.rifleammo == 0)
            {
                Debug.Log("Estas seco");
            }
        }

        if (currentAmmo <=0)
        {
            StartCoroutine(Reload());
            return;
        }
        
        ammomag.text = "" + currentAmmo;
    }

    void Shoot()
        {
            flash.Play();
            RaycastHit hit;
            currentAmmo--;
            if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range))
            {
                Debug.Log(hit.transform.name);
                Target target = hit.transform.GetComponent<Target>();
                if (target != null)
                {
                    target.Takedam(damage);
                }

                if(hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(-hit.normal * force);
                }

                GameObject imgo = Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(imgo, 2f);
            }
            Ammo.rifleammo -= 1;
            ManagerSonido.instance.Randomize(disparo);
    }

    IEnumerator Reload()
    {
        itsReload = true;
        ManagerSonido.instance.Randomize(ini);
        anim.SetBool("recargando", true);
        yield return new WaitForSeconds(reloadtime + 0.2f);
        ManagerSonido.instance.Randomize(fin);
        currentAmmo = maxAmmo;
        itsReload = false;
        anim.SetBool("recargando", false);
    }
}

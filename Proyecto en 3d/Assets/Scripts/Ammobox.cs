using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammobox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            Ammo.rifleammo += 30f;
            Destroy(gameObject);
        }
    }
}

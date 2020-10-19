using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class Damage : MonoBehaviour
{
    [SerializeField] private AudioClip sonido;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            PlayerManager.health -= 10f;
            Debug.Log("Atacado");
            AudioSource.PlayClipAtPoint(sonido, this.transform.position);
        }
    }*/
}

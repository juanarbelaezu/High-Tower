using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    Transform Character;
    public bool inside = false;
    private float heighfactor = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inside == true && Input.GetKeyDown(KeyCode.W))
        {
            Character.transform.position += Vector3.up / heighfactor;
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Ledder"))
        {
            inside = true;
        }

        if(collision.CompareTag("Desac"))
        {
            inside = false;
        }
    }
}

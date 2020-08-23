using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Follow : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] Transform t1, t2;
    public bool patrol = true;

    // Start is called before the first frame update
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(patrol)
        {
            agent.SetDestination(t1.position);
        }

        if (patrol == false)
        {
            agent.SetDestination(t1.position);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("t2"))
        {
            patrol = false;
        }

        if (collision.gameObject.CompareTag("t1"))
        {
            patrol = true;
        }
    }
}

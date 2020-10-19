using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour, IPooledEnemy
{

    [SerializeField] float lookradius = 10f;

    Transform target;
    NavMeshAgent agent;
    Animator an;
    public AudioClip zombie;
    
    // Start is called before the first frame update
    public void EnemyStart()
    {
        //target = PlayerManager.instance.player.transform;;
        target = GameObject.FindGameObjectWithTag("Tower").GetComponent<Transform>();
        agent = GetComponent<NavMeshAgent>();
        an = GetComponent<Animator>();
        ManagerSonido.instance.PlaySingle2(zombie);
        agent.Warp(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);        
        agent.SetDestination(target.position);
        an.SetBool("at", false);

        /*if(distance <= lookradius)
        {
            agent.SetDestination(target.position);
            an.SetBool("at", false);
        }*/

        if (distance <= /*agent.stoppingDistance*/ 2f)
        {
            Atacar();
            //Mirar al objetivo
            Facetarget();
        }

        
    }

    void Facetarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookrotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookrotation, Time.deltaTime * 5f);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookradius);
    }

    void Atacar()
    {
        an.SetBool("at", true);
    }

}

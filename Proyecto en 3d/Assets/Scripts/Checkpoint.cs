using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public bool activated = false;
    public static GameObject[] CheckPointsList;
    GameObject player;

    public static Vector3 GetActiveCheckPointPosition()
    {
        // If player die without activate any checkpoint, we will return a default position
        Vector3 result = new Vector3(0,0,0);

        if (CheckPointsList != null)
        {
            foreach (GameObject cp in CheckPointsList)
            {
                // We search the activated checkpoint to get its position
                if (cp.GetComponent<Checkpoint>().activated)
                {
                    result = cp.transform.position;
                    break;
                }
            }
        }

        return result;
    }

    private void ActivateCheckPoint()
    {
        foreach (GameObject cp in CheckPointsList)
        {
            cp.GetComponent<Checkpoint>().activated = false;
        }

        activated = true;
    }


    void Start()
    {
        CheckPointsList = GameObject.FindGameObjectsWithTag("CheckPoint");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ActivateCheckPoint();
        }
    }

}

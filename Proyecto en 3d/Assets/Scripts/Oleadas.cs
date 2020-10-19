using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Oleadas : MonoBehaviour
{

    /*[SerializeField] GameObject spawn1;
    [SerializeField] GameObject spawn2;
    [SerializeField] GameObject spawn3;
    [SerializeField] GameObject spawn4;
    [SerializeField] GameObject spawn5;
    [SerializeField] GameObject spawn6;
    [SerializeField] GameObject spawn7;
    [SerializeField] GameObject spawn8;
    [SerializeField] GameObject spawn9;*/

    [SerializeField] GameObject[] spawns;
    [SerializeField] float timer;
    [SerializeField] Text informe;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 0)
        {
            spawns[0].SetActive(true);
            spawns[1].SetActive(true);
            spawns[2].SetActive(true);
            informe.text = "Enemigos vienen por el sur";
        }

        if(timer >= 50)
        {
            spawns[0].SetActive(false);
            spawns[1].SetActive(false);
            spawns[2].SetActive(false);
            spawns[3].SetActive(true);
            spawns[4].SetActive(true);
            spawns[5].SetActive(true);
            informe.text = "Enemigos vienen por el norte";
        }

        if(timer >= 80)
        {
            spawns[0].SetActive(true);
            spawns[1].SetActive(true);
            spawns[2].SetActive(true);
            spawns[3].SetActive(true);
            spawns[4].SetActive(true);
            spawns[5].SetActive(true);
            spawns[6].SetActive(true);
            spawns[7].SetActive(true);
            spawns[8].SetActive(true);
            informe.text = "Enemigos vienen por todas direcciones";
        }
    }
}

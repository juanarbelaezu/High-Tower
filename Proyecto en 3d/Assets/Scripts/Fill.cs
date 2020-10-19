using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fill : MonoBehaviour
{

    public HealthTower torre;
    public Image barra;
    
    // Start is called before the first frame update
    void Start()
    {
        torre = GameObject.FindGameObjectWithTag("Tower").GetComponent<HealthTower>();
        barra = GameObject.FindGameObjectWithTag("Barra").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        barra.fillAmount = HealthTower.Vidatorre / 100;
    }
}

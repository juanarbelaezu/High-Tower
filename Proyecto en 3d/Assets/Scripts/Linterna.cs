using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Linterna : MonoBehaviour
{
    public GameObject linterna;
    private bool activo = false;
    public static float poder;
    private float maxpoder = 50f;
    private float cambio = 5f;
    public Image barra;
    public AudioClip on;


    // Start is called before the first frame update
    void Start()
    {
        poder = maxpoder;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Activarlinterna();
        }

        if(activo == false)
        {
            poder += cambio * Time.deltaTime;
        }

        if (poder > maxpoder)
        {
            poder = 50f;
        }

        if (activo == true)
        {
            poder -= cambio * Time.deltaTime;
        }

        if(poder <= 0)
        {
            poder = 0;
            linterna.gameObject.SetActive(false);
            activo = false;
            ManagerSonido.instance.Randomize(on);
        }

        barra.fillAmount = poder / maxpoder;
    }

    private void Activarlinterna()
    {
        if(activo == false && poder > 0)
        {
            linterna.gameObject.SetActive(true);
            activo = true;
            ManagerSonido.instance.Randomize(on);
        }
        else if(activo == false && poder == 0)
        {
            Debug.Log("Vacio");
            activo = false;
        }
        else if(activo == true)
        {
            linterna.gameObject.SetActive(false);
            activo = false;
            ManagerSonido.instance.Randomize(on);
        }
    }
    
}

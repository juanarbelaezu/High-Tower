using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    private Text texto;

    bool w = false;
    bool d = false;
    bool mov = false;
    bool disp = false;
    bool tuto = false;

    public GameObject inst;
    public GameObject inst2;
    public GameObject inst3;

    // Start is called before the first frame update
    void Start()
    {
        texto = GameObject.Find("Tutorial").GetComponent<Text>();
        texto.text = "Bienvenido. Puedes moverte con W,A,S,D";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            w = true;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            d = true;
        }

        if ((w == true && d == true) && mov == false)
        {
            texto.text = "Muy bien, ahora apunta con el ratón y dispara con click izquierdo";
            mov = true;
        }

        if(Input.GetButtonDown("Fire1") && mov == true && disp==false)
        {
            texto.text = "Felicidades has completado el tutorial";
            disp = true;
            tuto = true;
        }

        if (tuto)
        {
            inst.SetActive(false);
            inst2.SetActive(false);
            inst3.SetActive(false);
            texto.text = "";
        }
    }
}

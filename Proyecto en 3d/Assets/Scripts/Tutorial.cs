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
            texto.text = "Excelente, ahora usa barra espaciadora para saltar";
            disp = true;
        }

        if(Input.GetKeyDown(KeyCode.Space) && disp == true && tuto==false)
        {
            texto.text = "Bien, finalmente, usa F para encdender la linterna";
            tuto = true;

        }

        if (tuto && Input.GetKeyDown(KeyCode.F))
        {
            texto.text = "Enhobrabuena, ha completado el tutorial";
        }
    }
}

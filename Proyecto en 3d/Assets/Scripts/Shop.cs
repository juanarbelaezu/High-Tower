using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public GameObject panel;
    public Text killcount;
    private bool isactive;


    
    // Start is called before the first frame update
    void Start()
    {
        isactive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && isactive == false)
        {
            isactive = true;
            panel.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.T) && isactive == true)
        {
            isactive = false;
            panel.SetActive(false);
        }

        killcount.text = "" + PlayerManager.Killcount; 

        if(Input.GetKeyDown(KeyCode.Alpha9) && isactive == true)
        {
            BuyHealth();
        }

        if (Input.GetKeyDown(KeyCode.Alpha8) && isactive == true)
        {
            BuyAmmo();
        }

    }

    void BuyAmmo()
    {
        if(PlayerManager.Killcount > 10f)
        {
            PlayerManager.Killcount -= 10f;
            Ammo.rifleammo += 30f;
        }
        else
        {
            Debug.Log("No es posible comprar");
        }
    }

    void BuyHealth()
    {
        if (PlayerManager.Killcount > 10f)
        {
            PlayerManager.Killcount -= 10f;
            HealthTower.Vidatorre += 20;
        }
        else
        {
            Debug.Log("No es posible comprar");
        }
    }
}

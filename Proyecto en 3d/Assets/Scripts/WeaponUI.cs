using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponUI : MonoBehaviour
{

    public GameObject mainweapon;
    public GameObject pistol;
    public GameObject sniper;
    public GameObject cotrl;
    SwitchWeapons swiwep;

    // Start is called before the first frame update
    void Start()
    {
        SwitchWeapons swiwep = cotrl.GetComponent<SwitchWeapons>();
    }

    // Update is called once per frame
    void Update()
    {

        SwitchWeapons swiwep = cotrl.GetComponent<SwitchWeapons>();

        if (swiwep.selectweapon == 0)
        {
            mainweapon.SetActive(true);
            pistol.SetActive(false);
            sniper.SetActive(false);
        }

        if (swiwep.selectweapon == 1)
        {
            mainweapon.SetActive(false);
            pistol.SetActive(true);
            sniper.SetActive(false);
        }

        if (swiwep.selectweapon == 2)
        {
            mainweapon.SetActive(false);
            pistol.SetActive(false);
            sniper.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Misiones : MonoBehaviour
{

    public Text mision1;
    public Text mision2;
    public Text mision3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerManager.botiquin == 1)
        {
            Mission1();
        }

        if(PlayerManager.Killcount == 10)
        {
            Mission2();
        }
    }

    void Mission1()
    {
        mision1.gameObject.SetActive(false);
    }

    void Mission2()
    {
        mision2.gameObject.SetActive(false);
    }
}

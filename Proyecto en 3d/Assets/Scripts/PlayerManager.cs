using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;

    public GameObject player;

    public Image healthbar;
    private float maxhealth = 100f;
    public static float health;

    public static int botiquin = 0;
    public Image ins;
    private bool insact = false;

    public Text numbot;

    public Text time;

    private static float killcount;

    public Rigidbody rb;

    public static float Killcount { get => killcount; set => killcount = value; }

    public Transform pltp;

    private float t;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        health = maxhealth;
        killcount = 0f;
        t = 120;
    }



    void Update()
    {
        //healthbar.fillAmount = health / maxhealth;

        time.text = "" + t;

        if (Input.GetKeyDown(KeyCode.J)&& botiquin > 0)
        {
            Curar();
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            ActivarIn();
        }

        if (health > maxhealth)
        {
            health = maxhealth;
        }

        killcount = Killcount;

        t -= Time.deltaTime;

        if(t == 0f)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void Curar()
    {
        botiquin--;
        health += 20;
    }

    void ActivarIn()
    {
        if (insact == false)
        {
            ins.gameObject.SetActive(true);
            insact = true;
        }
        else if (insact == true)
        {
            ins.gameObject.SetActive(false);
            insact = false;
        }
    }
}

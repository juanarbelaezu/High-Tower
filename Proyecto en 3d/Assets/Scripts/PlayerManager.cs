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

    private static float killcount;

    public Rigidbody rb;

    public static float Killcount { get => killcount; set => killcount = value; }

    public Transform pltp;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        health = maxhealth;
        killcount = 0f;
    }



    void Update()
    {
        healthbar.fillAmount = health / maxhealth;

        if(Input.GetKeyDown(KeyCode.J)&& botiquin > 0)
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

        numbot.text = "" + botiquin;
        killcount = Killcount;


        //// Respawn Checkpoint
        if(health <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        ////////Checpoint
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

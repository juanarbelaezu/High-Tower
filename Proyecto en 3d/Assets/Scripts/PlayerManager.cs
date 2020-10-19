using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;

    public GameObject player;
    public Image ins;
    private bool insact = false;

    public Text numbot;

    public Text time;

    private static float killcount;

    public Rigidbody rb;

    public static float Killcount { get => killcount; set => killcount = value; }

    private float t;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        killcount = 0f;
        t = 120;
    }



    void Update()
    {
        //healthbar.fillAmount = health / maxhealth;

        float minutes = Mathf.FloorToInt(t / 60);
        float seconds = Mathf.FloorToInt(t % 60);

        time.text = minutes + ":" + seconds;

        if (Input.GetKeyDown(KeyCode.I))
        {
            ActivarIn();
        }

        killcount = Killcount;

        t -= Time.deltaTime;

        if(t == 0f)
        {
            SceneManager.LoadScene("GameOver");
        }
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

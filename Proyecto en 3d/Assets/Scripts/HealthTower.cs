using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthTower : MonoBehaviour
{

    public Image vida;
    [SerializeField] static float vidatorre;
    private float maxhealthtower;

    public static float Vidatorre { get => vidatorre; set => vidatorre = value; }

    // Start is called before the first frame update
    void Start()
    {
        maxhealthtower = 100f;
        vidatorre = maxhealthtower;
    }

    // Update is called once per frame
    void Update()
    {
        vida.fillAmount = vidatorre / maxhealthtower;

        if (vidatorre <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Attack"))
        {
            vidatorre -= 5;
            vida.fillAmount = vidatorre / maxhealthtower;
        }

        if(collision.gameObject.CompareTag("Tank"))
        {
            vidatorre -= 15;
            vida.fillAmount = vidatorre / maxhealthtower;
        }
    }

    
}

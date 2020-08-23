using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSonido : MonoBehaviour
{

    public AudioSource Effectos;
    public AudioSource Effectos2;
    public AudioSource Musica;
    public static ManagerSonido instance = null;

    public float tonobajo = .95f;
    public float tonoalto = 1.05f;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void PlaySingle(AudioClip clip)
    {
        Effectos.clip = clip;
        Effectos.Play();
    }

    public void PlaySingle2(AudioClip clip)
    {
        Effectos2.clip = clip;
        Effectos2.Play();
    }

    public void PlayMusic(AudioClip clip)
    {
        Musica.clip = clip;
        Musica.Play();
    }

    public void Randomize(params AudioClip[] clips)
    {
        int RandomIndex = Random.Range(0, clips.Length);
        float randomPitch = Random.Range(tonobajo, tonoalto);

        Effectos.pitch = randomPitch;
        Effectos.clip = clips[RandomIndex];
        Effectos.Play();
    }
}

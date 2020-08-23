using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMusic : MonoBehaviour
{
    [SerializeField] AudioClip clip;
    bool activated = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (activated == false && other.gameObject.tag=="Player")
        {
            GameObject.Find("SoundManager").GetComponent<ManagerSonido>().PlayMusic(clip);
            activated = true;

        }
    }
}

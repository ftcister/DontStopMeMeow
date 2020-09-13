using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip bulletsound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        bulletsound = Resources.Load<AudioClip>("bulletsonido");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip){
        switch (clip){
        case "bulletsonido":
            audioSrc.PlayOneShot (bulletsound);
            break;
        
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioClip[] clips;
    public AudioSource audio;
    public int klipSirasi;
    

    void Update()
    {
        if (klipSirasi == clips.Length)
        {
            klipSirasi = 0;
        }
         if (!audio.isPlaying)
        { 
            audio.clip = clips[klipSirasi];
            audio.Play();
            klipSirasi++;
        }
    }
}

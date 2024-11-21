using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBehaviour : MonoBehaviour
{
    public AudioSource music;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (music) {
                if (music.isPlaying)
                {
                    music.Stop();
                }
                else
                {
                    music.Play();
                }
           
        }
        }
        
    }
}

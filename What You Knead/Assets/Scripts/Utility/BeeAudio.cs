using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioSource sound = GetComponent<AudioSource>();
        sound.pitch = Random.Range(-0.5f, 2f);
        sound.volume = sound.volume * 2.3f;
    }

   
}

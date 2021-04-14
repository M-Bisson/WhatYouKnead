using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound {

    public string name;

    
    public static AudioSource source;

    [HideInInspector]
    public AudioClip clip = source.GetComponent<AudioClip>();

    [Range(0f,1f)]
    public float volume;
    [Range(.1f, 3f)]
    public float pitch;

    public bool loop;

    public AudioClip getClip()
    {
        return clip;
    }
   
}

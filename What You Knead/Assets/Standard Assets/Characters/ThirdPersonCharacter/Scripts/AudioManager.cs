using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // array of audio sounds
    public Sound[] sounds;

    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

        // check if there is an actual sound for the audio manager to play
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!"); // error message
            return; // nothing will play
        }
        // play sound
        s.source.Play();
    }
}

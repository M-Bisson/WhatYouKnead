using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTreeAudio : MonoBehaviour
{
    public GameObject tree;
    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
            
        }
    }
}

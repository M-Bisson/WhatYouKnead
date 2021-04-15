using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().pitch = Random.Range(0.1f, 1f);
    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRocks : MonoBehaviour
{
    public GameObject rocks;
    void OnTriggerEnter(Collider c)
    {
        if(c.tag == "Player")
        {
            rocks.SetActive(true);
        }
    }
}

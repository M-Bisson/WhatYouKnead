using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBees : MonoBehaviour
{
    public GameObject[] bees = new GameObject[5];

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject bee in bees){
            bee.SetActive(false);
        }
    }

    void OnTriggerEnter()
    {
        foreach(GameObject bee in bees){
            bee.SetActive(true);
        }
    }

}

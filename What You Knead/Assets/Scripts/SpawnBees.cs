using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBees : MonoBehaviour
{
    public GameObject[] bees = new GameObject[5];
    public GameObject honey;

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

    void Update()
    {
        foreach(GameObject bee in bees)
        {
            if (bee.activeSelf)
            {
                break;
            }
            honey.SetActive(true);
        }
    }

}

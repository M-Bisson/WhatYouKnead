using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBears : MonoBehaviour
{
    public GameObject[] bears = new GameObject[5];
    public GameObject berry;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject bear in bears)
        {
            bear.SetActive(false);
        }
    }

    void OnTriggerEnter()
    {
        foreach (GameObject bear in bears)
        {
            bear.SetActive(true);
        }
    }

    void Update()
    {
        foreach (GameObject bear in bears)
        {
            if (bear.activeSelf)
            {
                break;
            }
            berry.SetActive(true);
        }
    }
}

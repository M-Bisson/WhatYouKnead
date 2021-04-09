﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBears : MonoBehaviour
{
    public GameObject[] bears = new GameObject[5];
    public GameObject berry;
    public Inventory inventory;

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
            if (!inventory.hasBerry)
            {
                berry.SetActive(true);
            } else
            {
                berry.SetActive(false);
            }
            
        }
    }
}

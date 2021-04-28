using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBears : MonoBehaviour
{
    public GameObject[] bears = new GameObject[5];
    public GameObject berry;
    public Inventory inventory;
    private bool triggered;

    // Start is called before the first frame update
    void Start()
    {
        triggered = false;
        foreach (GameObject bear in bears)
        {
            bear.SetActive(false);
        }
    }

    void OnTriggerEnter()
    {
        if (!triggered)
        {
            foreach (GameObject bear in bears)
            {
                bear.SetActive(true);
            }
        }
        triggered = true;
    }

    void Update()
    {
        if (triggered)
        {
            foreach (GameObject bear in bears)
            {
                if (bear.activeSelf)
                {
                    break;
                }
                else
                {
                    berry.SetActive(true);
                    gameObject.SetActive(false);
                }

            }
        }
    }
}

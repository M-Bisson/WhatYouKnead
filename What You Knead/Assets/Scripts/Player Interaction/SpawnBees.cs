using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBees : MonoBehaviour
{
    public GameObject[] bees = new GameObject[5];
    public GameObject honey;
    public Inventory inventory;
    private bool triggered;

    // Start is called before the first frame update
    void Start()
    {
        triggered = false;
        foreach (GameObject bee in bees){
            bee.SetActive(false);
        }
    }

    void OnTriggerEnter()
    {
        if (!triggered)
        {
            foreach (GameObject bee in bees)
            {
                bee.SetActive(true);
            }
        }
        triggered = true;
    }

    void Update()
    {
        if (triggered)
        {
            foreach (GameObject bee in bees)
            {
                if (bee.activeSelf)
                {
                    break;
                }
                else
                {
                    honey.SetActive(true);
                    gameObject.SetActive(false);
                }

            }
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGrasshoppers : MonoBehaviour
{
    public GameObject[] grasshoppers = new GameObject[6];
    public GameObject wheat;
    public Inventory inventory;
    private bool triggered;

    // Start is called before the first frame update
    void Start()
    {
        triggered = false;
        foreach (GameObject gh in grasshoppers)
        {
            gh.SetActive(false);
        }
    }

    void OnTriggerEnter()
    {
        if (!triggered)
        {
            foreach (GameObject gh in grasshoppers)
            {
                gh.SetActive(true);
            }
        }
        triggered = true;

    }

    void Update()
    {
        if (triggered)
        {
            foreach (GameObject gh in grasshoppers)
            {
                if (gh.activeSelf)
                {
                    break;
                }
                else
                {
                    wheat.SetActive(true);
                    gameObject.SetActive(false);
                }

            }
        }
    }
}

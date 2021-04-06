using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGrasshoppers : MonoBehaviour
{
    public GameObject[] grasshoppers = new GameObject[6];
    public GameObject wheat;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject gh in grasshoppers)
        {
            gh.SetActive(false);
        }
    }

    void OnTriggerEnter()
    {
        foreach (GameObject gh in grasshoppers)
        {
            gh.SetActive(true);
        }
    }

    void Update()
    {
        foreach (GameObject gh in grasshoppers)
        {
            if (gh.activeSelf)
            {
                break;
            }
            wheat.SetActive(true);
        }
    }
}

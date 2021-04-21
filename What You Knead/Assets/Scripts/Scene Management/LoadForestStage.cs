using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadForestStage : MonoBehaviour
{
    public GameObject character;
    public GameObject inventory;
    public void OnTriggerEnter(Collider c)
    {
        if(c.tag == "Player")
        {
            DontDestroyOnLoad(character);
            DontDestroyOnLoad(inventory);
            SceneManager.LoadScene("Forest");
        }
    }
}

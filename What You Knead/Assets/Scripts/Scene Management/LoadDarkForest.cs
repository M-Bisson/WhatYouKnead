using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadDarkForest : MonoBehaviour
{
    public GameObject character;

    public void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Player")
        {
            DontDestroyOnLoad(character);
            SceneManager.LoadScene("DarkForest");
        }
    }
}

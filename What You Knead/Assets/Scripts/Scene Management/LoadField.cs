using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadField : MonoBehaviour
{
    public GameObject character;
    public GameObject invPanel;

    public void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Player")
        {
            DontDestroyOnLoad(character);
            SceneManager.LoadScene("Field");
        }
    }
}

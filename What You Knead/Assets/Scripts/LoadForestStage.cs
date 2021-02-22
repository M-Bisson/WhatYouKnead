using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadForestStage : MonoBehaviour
{
    void OnTriggerEnter(Collider c)
    {
        if(c.tag == "Player")
        {
            SceneManager.LoadScene("Forest");
        }
    }
}

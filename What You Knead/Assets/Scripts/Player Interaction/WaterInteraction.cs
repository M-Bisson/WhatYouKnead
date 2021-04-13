using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterInteraction : MonoBehaviour
{
    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Player")
        {
            Scene scene = SceneManager.GetActiveScene(); 
            SceneManager.LoadScene(scene.name);
        }
    }
}

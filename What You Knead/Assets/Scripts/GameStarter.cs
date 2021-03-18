using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameStarter : MonoBehaviour
{
    public void StartGame()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Village" || scene.name == "Menu")
        {
            SceneManager.LoadScene("Village");
        } else if (scene.name == "Forest")
        {
            SceneManager.LoadScene("Forest");
        } else if (scene.name == "DarkForest")
        {
            SceneManager.LoadScene("DarkForest");
        } else if (scene.name == "Field")
        {
            SceneManager.LoadScene("Field");
        }
    }
}

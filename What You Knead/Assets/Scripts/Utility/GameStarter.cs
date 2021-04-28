using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GameStarter : MonoBehaviour
{
    public AudioSource sound_menu;
    public AudioSource sound_startGame;
    public void StartGame()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "Village" || scene.name == "Menu")
        {
            if (EventSystem.current.currentSelectedGameObject.name == "HowToPlay")
            {
                sound_menu.Play();
                SceneManager.LoadScene("HowToPlay");
            }
            else
            {
                sound_startGame.Play();
                SceneManager.LoadScene("Village");
            }
        }
        else if (scene.name == "Forest")
        {
            SceneManager.LoadScene("Forest");
        }
        else if (scene.name == "DarkForest")
        {
            SceneManager.LoadScene("DarkForest");
        }
        else if (scene.name == "Field")
        {
            SceneManager.LoadScene("Field");
        }
        else if (scene.name == "HowToPlay")
        {
            if (EventSystem.current.currentSelectedGameObject.name == "BackButton")
            {
                sound_menu.Play();
                SceneManager.LoadScene("Menu");
            }
        } else if (scene.name == "VillageEndScene") {
            if (EventSystem.current.currentSelectedGameObject.name == "WinCreditsButton" ||
                EventSystem.current.currentSelectedGameObject.name == "LoseCreditsButton")
            {
                SceneManager.LoadScene("Credits");
            }
        }
    }
}

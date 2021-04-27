using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int lives;
    public bool hasIngredients;
    public AudioSource footsteps;
    public Image cutscene;
    public Button button;
    //public Image winScene;
    //public Button winExitButton;
    //public Image loseScene;
    //public Button loseExitButton;

    // Start is called before the first frame update
    void Start()
    {
        lives = 5;
        hasIngredients = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (!footsteps.isPlaying)
            {
                footsteps.Play();
            }
        }
        else
        {
            footsteps.Stop();
        }

        if (lives <= 0)
        {
            cutscene.gameObject.SetActive(true);
            button.gameObject.SetActive(true);

            //Scene scene = SceneManager.GetActiveScene();
            //if (scene.name == "DarkForest" && gameObject.name == "ForestCharacter")
            //{
            //    DontDestroyOnLoad(gameObject);
            //}
            //if (scene.name == "Field" && gameObject.name == "DarkForestCharacter")
            //{
            //    DontDestroyOnLoad(gameObject);
            //}

            //SceneManager.LoadScene(scene.name);

            //cutscene.gameObject.SetActive(true);
            //button.gameObject.SetActive(true);

        }

        //if (hasIngredients)
        //{
        //    endScene.gameObject.SetActive(true);
        //    quitButton.gameObject.SetActive(true);
        //}
        //Scene scene = SceneManager.GetActiveScene();
        //if (scene.name == "VillageEndScene" && hasIngredients)
        //{
        //    winScene.gameObject.SetActive(true);
        //    winExitButton.gameObject.SetActive(true);
        //}
        //if (scene.name == "VillageEndScene" && !hasIngredients)
        //{
        //    loseScene.gameObject.SetActive(true);
        //    loseExitButton.gameObject.SetActive(true);
        //}
    }

    public void gotIngredients()
    {
        hasIngredients = true;
    }

    public void reloadScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Forest" && gameObject.name == "VillageCharacter")
        {
            DontDestroyOnLoad(gameObject);
        }
        if (scene.name == "DarkForest" && gameObject.name == "ForestCharacter")
        {
            DontDestroyOnLoad(gameObject);
        }
        if (scene.name == "Field" && gameObject.name == "DarkForestCharacter")
        {
            DontDestroyOnLoad(gameObject);
        }

        SceneManager.LoadScene(scene.name);
    }
}
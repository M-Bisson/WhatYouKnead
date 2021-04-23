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
    //public Image cutscene;
    //public Button button;

    // Start is called before the first frame update
    void Start()
    {
        lives = 5;
        hasIngredients = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (!footsteps.isPlaying)
            {
                footsteps.Play();
            }
        } else
        {
            footsteps.Stop();
        }

        if (lives <= 0)
        {

            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "DarkForest" && gameObject.name == "ForestCharacter")
            {
                DontDestroyOnLoad(gameObject);
            }
            if (scene.name == "Field" && gameObject.name == "DarkForestCharacter")
            {
                DontDestroyOnLoad(gameObject);
            }
            SceneManager.LoadScene(scene.name);

            //if (scene.name == "Forest")
            //{
            //    cutscene.gameObject.SetActive(true);
            //    button.gameObject.SetActive(true);
            //}

        }
    }

    public void gotIngredients()
    {
        hasIngredients = true;
    }
}

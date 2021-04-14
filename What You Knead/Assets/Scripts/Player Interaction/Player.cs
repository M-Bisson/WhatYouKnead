using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int lives;
    public bool hasIngredients;
    public AudioSource footsteps;
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

        if(lives <= 0)
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);

        }
    }

    public void gotIngredients()
    {
        hasIngredients = true;
    }
}

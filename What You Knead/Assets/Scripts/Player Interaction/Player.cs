using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int lives;
    public bool hasIngredients;
    // Start is called before the first frame update
    void Start()
    {
        lives = 5;
        hasIngredients = false;
    }

    // Update is called once per frame
    void Update()
    {
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CanvasGroup))]
public class PauseMenuToggle : MonoBehaviour
{   
    private CanvasGroup canvasGroup;
    public bool gameStarted;
    // Start is called before the first frame update

    private void Start()
    {
        gameStarted = false;
        Cursor.lockState = CursorLockMode.None;

        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Forest" || scene.name == "Field" || scene.name == "DarkForest")
        {
            gameStarted = true;
        }
    }

    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && gameStarted)
        {
            if (canvasGroup.interactable)
            {
                canvasGroup.interactable = false; canvasGroup.blocksRaycasts = false; canvasGroup.alpha = 0f;
                Time.timeScale = 1f;
                //Cursor.lockState = CursorLockMode.Locked;
                //Cursor.visible = false;
            }
            else {
                canvasGroup.interactable = true; canvasGroup.blocksRaycasts = true; canvasGroup.alpha = 1f;
                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;

            }
        } 

    }
}

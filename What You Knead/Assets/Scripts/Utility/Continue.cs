using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Continue : MonoBehaviour
{
    public Image startImage;
    public PauseMenuToggle pauseMenu;
    public AudioSource sound;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void ContinueToPlay()
    {
        sound.Play();
        pauseMenu.gameStarted = true;
        startImage.gameObject.SetActive(false);
        //Cursor.lockState = CursorLockMode.Locked;
        gameObject.SetActive(false);

    }
}

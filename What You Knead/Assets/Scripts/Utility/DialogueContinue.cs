using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueContinue : MonoBehaviour
{
    public Canvas dialogueBox;
    //public PauseMenuToggle pauseMenu;
    public AudioSource sound;
    
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.None;
        dialogueBox.gameObject.SetActive(false);
    }

    public void ContinueToPlay()
    {
        sound.Play();
        //pauseMenu.gameStarted = true;
        dialogueBox.gameObject.SetActive(false);
        //Cursor.lockState = CursorLockMode.Locked;
        gameObject.SetActive(false);

    }
}

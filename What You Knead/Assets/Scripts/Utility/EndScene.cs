﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScene : MonoBehaviour
{
    public Image win;
    public Image lose;
    public Button winButton;
    public Button loseButton;
    private GameObject character;

    void Awake()
    {
        character = GameObject.Find("FieldCharacter");
        character.GetComponent<Inventory>().enabled = (false);
    }
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        if(character.GetComponent<Player>().hasIngredients == true)
        {
            lose.enabled = false;
            loseButton.gameObject.SetActive(false);
        } else
        {
            win.enabled = false;
            winButton.gameObject.SetActive(false);
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public Image[] lives;
    public int livesRemaining = 5;
    public Player player;

    void Start()
    {
    }

    void Update()
    {
        
        //GameObject[] temp;
        //GameObject i;

        //while (lives != player.lives)
        //{
        //    temp = new GameObject[player.lives];
        //    livesIcons.CopyTo(temp, 0);
        //    livesIcons = temp;

        //    i = Instantiate(livesIcons[0]);
        //    i.transform.SetParent(livesPanel.transform);
        //    lives++;
        //}

        while (livesRemaining > player.lives)
        {
            livesRemaining--;

            lives[livesRemaining].enabled = false;
        }

    }


}



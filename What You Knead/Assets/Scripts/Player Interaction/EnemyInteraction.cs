using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInteraction : MonoBehaviour
{
    public Player player;
    public AudioSource hitPlayer;
    public AudioSource killPlayer;
    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Player")
        {
            if (player.lives > 2)
            {
                if (hitPlayer != null)
                {
                    hitPlayer.Play();
                }
                else
                {
                    Debug.LogError("Player Hit Sound Not Found!");
                }

            }
            else
            {
                if (killPlayer != null)
                {
                    killPlayer.Play();
                }
                else
                {
                    Debug.LogError("Player Death Sound Not Found!");
                }
            }

            player.lives--;


        }
    }
}

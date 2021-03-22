using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInteraction : MonoBehaviour
{
    public Player player;
    void OnTriggerEnter(Collider c)
    {
        if(c.tag == "Player")
        {
            player.lives--;
        }
    }
}

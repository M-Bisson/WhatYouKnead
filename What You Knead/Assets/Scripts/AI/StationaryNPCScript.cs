using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationaryNPCScript : MonoBehaviour
{

    public GameObject NPC;
    public GameObject Player;

    public Canvas dialogueBox;
    public GameObject button;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(NPC.transform.position, Player.transform.position) < 0.2)
        {
            dialogueBox.gameObject.SetActive(true);
            button.gameObject.SetActive(true);
        }
    }
}

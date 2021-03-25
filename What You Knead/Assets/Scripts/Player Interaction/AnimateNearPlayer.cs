using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateNearPlayer : MonoBehaviour
{

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Player")
        {
            anim.SetBool("PlayerNear", true);

        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.tag == "Player")
        {
            anim.SetBool("PlayerNear", false);

        }
    }
}
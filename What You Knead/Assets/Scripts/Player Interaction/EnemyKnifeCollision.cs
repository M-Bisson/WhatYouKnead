using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKnifeCollision : MonoBehaviour
{
    public ThrowingKnife knife;
    public AudioSource sound;
    void OnTriggerEnter(Collider c)
    {
        Debug.Log(c.tag);
        if(c.tag == "knife")
        {
            if (sound != null)
            {
                sound.Play();
            } else
            {
                Debug.LogError("Cannot find audio source!");
            }

            Debug.Log("disable bee");
            c.gameObject.SetActive(false);
            this.transform.parent.gameObject.SetActive(false);
        }
    }
}

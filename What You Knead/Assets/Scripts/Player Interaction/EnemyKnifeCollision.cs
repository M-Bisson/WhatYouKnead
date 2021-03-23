using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKnifeCollision : MonoBehaviour
{
    public ThrowingKnife knife;
    void OnTriggerEnter(Collider c)
    {
        Debug.Log(c.tag);
        if(c.tag == "knife")
        {
            Debug.Log("disable bee");
            c.gameObject.SetActive(false);
            this.transform.parent.gameObject.SetActive(false);
        }
    }
}

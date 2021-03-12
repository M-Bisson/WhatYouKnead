using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKnifeCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider c)
    {
        Debug.Log(c.tag);
        if(c.tag == "knife")
        {
            Debug.Log("disable bee");
            this.transform.parent.gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeFall : MonoBehaviour
{
    public GameObject tree;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = tree.GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider c)
    {
        if(c.tag == "Player")
        {
            rb.constraints = RigidbodyConstraints.None;
            gameObject.SetActive(false);
        }
    }
}

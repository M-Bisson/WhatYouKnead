using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingKnife : MonoBehaviour
{
    public int knives = 0;
    public int throwSpeed = 5;
    public GameObject knifeTemplate;
    Vector3 knifeOffset = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        //if you have a knife and right click, throw it
        if (Input.GetMouseButtonDown(1) && knives > 0)
        {
            Debug.Log("Throwing Knife");
            Vector3 worldOffset = transform.rotation * knifeOffset;
            GameObject cloneKnife = Instantiate(knifeTemplate, transform.position + worldOffset, transform.rotation) as GameObject;
            cloneKnife.GetComponent<MeshRenderer>().enabled = true;
            cloneKnife.transform.localScale = new Vector3(7, 7, 7);
            cloneKnife.GetComponent<Rigidbody>().AddForce(transform.forward * throwSpeed, ForceMode.Impulse);
            knives -= 1;
        }
    }
}

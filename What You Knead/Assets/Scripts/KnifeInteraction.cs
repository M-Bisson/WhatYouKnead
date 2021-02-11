using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeInteraction : MonoBehaviour
{
    public ThrowingKnife knife;
    public float throwSpeed = 10;
    public int knives = 0;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //if you have a knife and right click, throw it
        //if (Input.GetMouseButtonDown(1) && knives > 0)
        //{
        //    Debug.Log("Throwing Knife");
        //    GameObject cloneKnife = Instantiate(knife, knife.transform.position, knife.transform.rotation) as GameObject;
        //    cloneKnife.GetComponent<MeshRenderer>().enabled = true;
        //    cloneKnife.transform.localScale = new Vector3(10, 10, 10);
        //    cloneKnife.GetComponent<Rigidbody>().AddForce(cloneKnife.transform.forward * throwSpeed);
        //    knives -= 1;
        //}
    }

    void pickUpKnife()
    {
        Debug.Log("Picked up Knife");
        knife.knives++;
        gameObject.SetActive(false);
    }
    
    void OnMouseOver()
    {
        rend.material.color = Color.blue;
        //if you click and are in the plane pick the knife up
        if (Input.GetMouseButtonDown(0) && gameObject.tag == "knife")
        {
            pickUpKnife();
        }

    }
}


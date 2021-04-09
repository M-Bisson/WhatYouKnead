using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheatInteraction : MonoBehaviour
{
    public Inventory inventory;

    void Start()

    {
        //gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }

    void pickUpWheat()
    {
        //Debug.Log("Picked up Wheat");
        inventory.wheat++;
        gameObject.SetActive(false);
    }

    void OnMouseOver()
    {
        if (gameObject.tag == "wheat")
        {
            transform.Find("Cube").GetComponent<Renderer>().material.color = Color.blue;
        }
        //if you click and are in the plane pick the wheat up
        if (Input.GetMouseButtonDown(0) && gameObject.tag == "wheat")
        {
            pickUpWheat();
        }

    }

}

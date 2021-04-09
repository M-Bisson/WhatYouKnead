using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoneycombInteraction : MonoBehaviour
{
    //public GameObject character;
    //public int honeycombs = 0;
    public Inventory inventory;

    void Start()

    {
        //gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }

    void pickUpHoneycomb()
    {
        //Debug.Log("Picked up Honeycomb");
        inventory.honeycombs++;
        gameObject.SetActive(false);
    }

    void OnMouseOver()
    {
        if (gameObject.tag == "honeycomb")
        {
            transform.Find("HoneyComb.003").GetComponent<Renderer>().material.color = Color.blue;
        }
        //if you click and are in the plane pick the honeycomb up
        if (Input.GetMouseButtonDown(0) && gameObject.tag == "honeycomb")
        {
            pickUpHoneycomb();
        }

    }

}

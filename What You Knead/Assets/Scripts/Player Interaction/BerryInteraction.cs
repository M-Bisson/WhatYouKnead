using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerryInteraction : MonoBehaviour
{
    public Inventory inventory;
    public AudioSource sound;

    void Start()

    {
        //gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }

    void pickUpBerry()
    {
        //Debug.Log("Picked up Berry");
        sound.Play();
        inventory.berries++;
        gameObject.SetActive(false);
    }

    void OnMouseOver()
    {
        if (gameObject.tag == "berry")
        {
            transform.Find("Sphere").GetComponent<Renderer>().material.color = Color.blue;
        }
        //if you click and are in the plane pick the berry up
        if (Input.GetMouseButtonDown(0) && gameObject.tag == "berry")
        {
            pickUpBerry();
        }

    }

}

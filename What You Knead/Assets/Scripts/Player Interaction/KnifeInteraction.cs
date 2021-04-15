using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeInteraction : MonoBehaviour
{
    public ThrowingKnife knife;
    public float throwSpeed = 1;
    public GameObject character;
    public int knives = 0;
    private Renderer rend;
    private Camera cam;
    public AudioSource sound;

    void Start()

    {
        gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }


    void pickUpKnife()
    {
        //Debug.Log("Picked up Knife");
        knife.knives++;
        gameObject.SetActive(false);
    }

    void OnMouseOver()
    {
        transform.Find("Blade").GetComponent<Renderer>().material.color = Color.blue;
        //if you click and are in the plane pick the knife up
        if (Input.GetMouseButtonDown(0) && gameObject.tag == "knife")
        {
            // add sound effect
            if (sound != null)
            {
                sound.Play();
            }
            else // sound not found
            {
                Debug.LogError("Could not find sound!");
            }
            pickUpKnife();
        }

    }


}

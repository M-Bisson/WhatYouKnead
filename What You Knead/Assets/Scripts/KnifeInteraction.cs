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

    void Start()

    {
        //cam = Camera.main;
        //if (gameObject.layer == 8 && gameObject.name != "knifeParent")
        //{
        //    //Vector3 worldMousePosition = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.nearClipPlane));
        //    //Vector3 direction = worldMousePosition - character.transform.position;
        //    //Debug.Log(direction);
        //    gameObject.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(1, 0, 0) * throwSpeed, ForceMode.Impulse);
        //}
        gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
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

    void OnCollisionEnter(Collision coll)
    {
        //if (coll.gameObject.tag != "throwPlane")
        //{
            Debug.Log("Collision object: " + coll.gameObject.name);
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            gameObject.GetComponent<Rigidbody>().useGravity = false;
        //}
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour //https://forum.unity.com/threads/door-open-close-in-c.410811/
{
    // the door from this object
    public GameObject DoorObject;
    // the door copied and rotated/moved to be the opened door
    public GameObject DoorOpen;
    // this will be a copy of the original door so that we have some numbers to work with.
    private GameObject DoorClosed;
    // this controls if the door is opened or closed.
    public bool isOpened = false;
    ////door parent
    //public GameObject parent;

    // this is the movement rate (if movemnt is applied to the door)
    public float moveSpeed = 3;
    // this is the rotation rate (if rotation is applied to the door)
    public float rotationSpeed = 90;

    void Start()
    {
        // copy the door to keep its position
        DoorClosed = Instantiate(DoorObject, DoorObject.transform.position, DoorObject.transform.rotation);
        // hide both the open and closed door
        DoorClosed.SetActive(false);
        DoorOpen.SetActive(false);
    }

    void Update()
    {
        // every frame, move the door towards the Open/Closed door
        GameObject target = isOpened ? DoorOpen : DoorClosed;
        // move visible door toward closed/open door position
        DoorObject.transform.position = Vector3.MoveTowards(DoorObject.transform.position, target.transform.position, moveSpeed * Time.deltaTime);
        DoorObject.transform.rotation = Quaternion.RotateTowards(DoorObject.transform.rotation, target.transform.rotation, rotationSpeed * Time.deltaTime);
    }

    void OnMouseOver()
    {
        // whenever player clicks, open the door
        if (Input.GetMouseButtonDown(0))
        {
            isOpened = !isOpened;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseView : MonoBehaviour //https://answers.unity.com/questions/1390197/how-to-make-my-camera-only-rotate-on-middle-mouse.html
{

    private const float Y_ANGLE_MIN = 10.0f;
    private const float Y_ANGLE_MAX = 35.0f;
    private const float DISTANCE_MAX = 1.0f;
    private const float DISTANCE_MIN = 0.2f;
    private const float TRANS_MIN = 1.0f;
    private const float TRANS_MAX = 2.0f;
    public Transform camTransform;
    public Transform lookAt;
    private float currentX;
    private float currentY;
    private float distance;
    private float trandis;
    private float sensitivityX = 4.0f;
    private float sensitivityY = 1.0f;
    public Vector3 height = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        currentX = 0.0f;
        currentY = 0.0f;
        distance = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(2))
        {
            currentX += Input.GetAxis("Mouse X") * sensitivityX;
            currentY += Input.GetAxis("Mouse Y") * sensitivityY;
        }
        //Limits the Y variable
        currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
        //Thiago Laranja's scrollwheel implemetation.
        if (Input.GetAxis("Mouse ScrollWheel") > 0) { distance -= 0.1f; }
        if (Input.GetAxis("Mouse ScrollWheel") < 0) { distance += 0.1f; }
        //Makes sure that these variables never go over the max and be les than the min.
        distance = Mathf.Clamp(distance, DISTANCE_MIN, DISTANCE_MAX);
        trandis = Mathf.Clamp(distance, TRANS_MIN, TRANS_MAX) - 1;

    }

    private void LateUpdate()
    {
        //Subtracts the distance from Z coordinate
        Vector3 dir = new Vector3(0, 0, -distance);
        //Creates an quaternion for rotation(too bad that we cannot use Vector3.
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        //Sets the cameras position and makes it look at player.
        camTransform.position = lookAt.position + height + rotation * dir;
        camTransform.LookAt(lookAt.position + height);
    }
}

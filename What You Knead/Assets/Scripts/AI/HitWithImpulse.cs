using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitWithImpulse : MonoBehaviour
{
    private Rigidbody rb;
    public float impulseForce = 1f;
    public bool grounded = true;
    public float timeOfLastEvent;
    public float minTimeBetweenEvents = 5f; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        
    }

    void OnCollisionEnter(Collision collision)
    {
        grounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        grounded = false; 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var currentTime = Time.time; 

        if (currentTime > (timeOfLastEvent + minTimeBetweenEvents))
        {
            rb.AddForce(Vector3.up * impulseForce, ForceMode.Impulse);
            impulseForce = Random.Range(1f, 2f);
            minTimeBetweenEvents = Random.Range(2f, 6f);
            timeOfLastEvent = Time.time; 
        }
        
    }
}

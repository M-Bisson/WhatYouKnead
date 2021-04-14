using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingKnife : MonoBehaviour
{
    public int knives = 0;
    public int throwSpeed = 5;
    public Transform character;
    public GameObject knifeTemplate;
    Vector3 knifeOffset = new Vector3(0, 0, 0);
    public GameObject knifeSpawnPoint;
    public Inventory inventory;
    public AudioSource sound;

    // Update is called once per frame
    void Update()
    {
        inventory.knives = knives;
        //if you have a knife and right click, throw it
        if (Input.GetMouseButtonDown(1) && knives > 0)
        {
            //Debug.Log("Throwing Knife");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // add sound effect
            if (sound != null)
            {
                sound.Play();
            }
            else
            {
                Debug.LogWarning("Could not find sound!");
            }

            if (Physics.Raycast(ray, out hit))
            {
                // cache oneSpawn object in spawnPt, if not cached yet
                if (!knifeSpawnPoint) knifeSpawnPoint = GameObject.Find("ThrowingKnife");
                GameObject projectile = Instantiate(knifeTemplate, knifeSpawnPoint.transform.position, Quaternion.identity) as GameObject;
                // turn the projectile to hit.point
                projectile.transform.LookAt(hit.point);
                // accelerate it
                projectile.GetComponent<Rigidbody>().AddForce(projectile.transform.forward * throwSpeed, ForceMode.Impulse);
            }
            knives -= 1;
        }

    }

}

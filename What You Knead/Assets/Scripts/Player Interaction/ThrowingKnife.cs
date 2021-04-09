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
            if (Physics.Raycast(ray, out hit))
            {
                //Debug.DrawLine(character.position, hit.point);
                // cache oneSpawn object in spawnPt, if not cached yet
                if (!knifeSpawnPoint) knifeSpawnPoint = GameObject.Find("ThrowingKnife");
                GameObject projectile = Instantiate(knifeTemplate, knifeSpawnPoint.transform.position, Quaternion.identity) as GameObject;
                // turn the projectile to hit.point
                projectile.transform.LookAt(hit.point);
                //projectile.GetComponent<MeshRenderer>().enabled = true;
                // accelerate it
                projectile.GetComponent<Rigidbody>().AddForce(projectile.transform.forward * throwSpeed, ForceMode.Impulse);
            }
            ////Vector3 worldOffset = transform.rotation * knifeOffset;
            //GameObject cloneKnife = Instantiate(knifeTemplate, gameObject.transform.position, character.transform.rotation) as GameObject;
            //cloneKnife.transform.Rotate(0, 180, 0);
            //cloneKnife.GetComponent<MeshRenderer>().enabled = true;
            //cloneKnife.transform.localScale = new Vector3(10, 10, 10);
            ////Debug.Log(cloneKnife.transform.forward);
            //Vector3 throwAlongThis = character.transform.position - gameObject.transform.position;
            //Debug.Log(throwAlongThis);
            //cloneKnife.GetComponent<Rigidbody>().AddRelativeForce(throwAlongThis * throwSpeed, ForceMode.Impulse);
            knives -= 1;
        }

    }
}

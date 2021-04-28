using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestStart : MonoBehaviour
{
    private GameObject character;
    private Transform knife;
    public GameObject forestCharacter;
    public ThrowingKnife newKnife;
    private ThrowingKnife oldKnife;
    public GameObject inventoryPan;
    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("VillageCharacter");
        character.GetComponent<Inventory>().inventoryPanel = inventoryPan;
        knife = character.transform.Find("throwing knife");
        Debug.Log("Village boi: " + character);
        if (character != null)
        {
            character.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            Vector3 pos = character.transform.position;
            pos.y = 4;
            character.transform.position = pos;
            oldKnife = knife.GetComponent<ThrowingKnife>();
            Debug.Log("knife??: " + oldKnife);
            newKnife.knives = oldKnife.knives;
            //character.SetActive(false);
            Debug.Log("knives from last scene: " + newKnife.knives);
            knife.GetComponent<ThrowingKnife>().enabled = (false);
        }
    }

}

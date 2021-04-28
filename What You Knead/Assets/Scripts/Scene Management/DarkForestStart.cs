using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkForestStart : MonoBehaviour
{
    private GameObject character;
    private Transform knife;
    public GameObject darkForestCharacter;
    public ThrowingKnife newKnife;
    private ThrowingKnife oldKnife;
    public Inventory newInventory;
    private Inventory oldInventory;
    public GameObject inventoryPan;
    private GameObject oldChar;
    // Start is called before the first frame update
    void Start()
    {
        oldChar = GameObject.Find("VillageCharacter");
        if (oldChar != null)
        {
            oldChar.SetActive(false);
            Debug.Log("Village character deleted");
        }
        character = GameObject.Find("ForestCharacter");
        knife = character.transform.Find("throwing knife");
        Debug.Log("Forest boi: " + character);
        character.GetComponent<Inventory>().inventoryPanel = inventoryPan;
        oldInventory = character.GetComponent<Inventory>();
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
            //---------------------------
            newInventory.honeycombs = oldInventory.honeycombs;
            Debug.Log("honeycombs from last scene: " + newInventory.honeycombs);
            knife.GetComponent<ThrowingKnife>().enabled = (false);
        }
    }
}

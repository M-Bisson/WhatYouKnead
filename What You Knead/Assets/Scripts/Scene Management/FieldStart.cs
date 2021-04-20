using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FieldStart : MonoBehaviour
{
    private GameObject character;
    private Transform knife;
    public GameObject fieldCharacter;
    public ThrowingKnife newKnife;
    private ThrowingKnife oldKnife;
    public Inventory newInventory;
    private Inventory oldInventory;
    // Start is called before the first frame update
    void Awake()
    {
        GameObject inventory = GameObject.Find("InventoryPanel");
        character = GameObject.Find("DarkForestCharacter");
        newInventory.inventoryPanel = inventory;
        knife = character.transform.Find("throwing knife");
        Debug.Log("DarkForest boi: " + character);
        oldInventory = character.GetComponent<Inventory>();
        fieldCharacter.GetComponent<Inventory>().knifeInv = true;
        if (oldInventory.honeyInv) { 
            fieldCharacter.GetComponent<Inventory>().honeyInv = true;
        }
        if (oldInventory.berryInv)
        {
            fieldCharacter.GetComponent<Inventory>().berryInv = true;
        }
        if (character != null)
        {
            character.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            oldKnife = knife.GetComponent<ThrowingKnife>();
            Debug.Log("knife??: " + oldKnife);
            newKnife.knives = oldKnife.knives;
            //character.SetActive(false);
            //Debug.Log("knives from last scene: " + newKnife.knives);
            //newInventory.honeycombs = oldInventory.honeycombs;
            //Debug.Log("honeycombs from last scene: " + newInventory.honeycombs);
            //newInventory.berries = oldInventory.berries;
            //Debug.Log("berries from last scene: " + newInventory.berries);
        }
    }
}

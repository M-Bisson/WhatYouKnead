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
    public GameObject inventoryPan;
    // Start is called before the first frame update
    void Start()
    {
        GameObject oldChar = GameObject.Find("ForestCharacter");
        oldChar.SetActive(false);
        Debug.Log("Forest character deleted");
        character = GameObject.Find("DarkForestCharacter");
        character.GetComponent<Inventory>().inventoryPanel = inventoryPan;
        Debug.Log("DarkForest inventory fixed");
        knife = character.transform.Find("throwing knife");
        Debug.Log("DarkForest boi: " + character);
        oldInventory = character.GetComponent<Inventory>();
        //fieldCharacter.GetComponent<Inventory>().knifeInv = true;
        //if (oldInventory.honeyInv) { 
        //    fieldCharacter.GetComponent<Inventory>().honeyInv = true;
        //}
        //if (oldInventory.berryInv)
        //{
        //    fieldCharacter.GetComponent<Inventory>().berryInv = true;
        //}
        if (character != null)
        {
            character.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            Vector3 pos = character.transform.position;
            pos.y = 4;
            character.transform.position = pos;
            oldKnife = knife.GetComponent<ThrowingKnife>();
            Debug.Log("knife??: " + oldKnife);
            newKnife.knives = oldKnife.knives;
            Debug.Log("knives from last scene: " + newKnife.knives);
            newInventory.honeycombs = oldInventory.honeycombs;
            Debug.Log("honeycombs from last scene: " + newInventory.honeycombs);
            newInventory.berries = oldInventory.berries;
            Debug.Log("berries from last scene: " + newInventory.berries);
        }
    }
}

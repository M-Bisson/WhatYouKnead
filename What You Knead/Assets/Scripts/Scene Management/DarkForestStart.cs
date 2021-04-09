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
    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("ForestCharacter");
        knife = character.transform.Find("throwing knife");
        Debug.Log("Forest boi: " + character);
        oldInventory = character.GetComponent<Inventory>();
        if (character != null)
        {
            oldKnife = knife.GetComponent<ThrowingKnife>();
            Debug.Log("knife??: " + oldKnife);
            newKnife.knives = oldKnife.knives;
            character.SetActive(false);
            Debug.Log("knives from last scene: " + newKnife.knives);
            //---------------------------
            newInventory.honeycombs = oldInventory.honeycombs;
            Debug.Log("honeycombs from last scene: " + newInventory.honeycombs);
            newInventory.hasHoneycomb = oldInventory.hasHoneycomb;
            Debug.Log("hasHoneycomb from last scene: " + newInventory.honeycombs);
        }
    }
}

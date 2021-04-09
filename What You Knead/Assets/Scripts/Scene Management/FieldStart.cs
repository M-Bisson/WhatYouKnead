using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillageEndStart : MonoBehaviour
{
    private GameObject character;
    private Transform knife;
    public GameObject fieldCharacter;
    public ThrowingKnife newKnife;
    private ThrowingKnife oldKnife;
    public Inventory newInventory;
    private Inventory oldInventory;
    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("DarkForestCharacter");
        knife = character.transform.Find("throwing knife");
        Debug.Log("Village boi: " + character);
        oldInventory = character.GetComponent<Inventory>();
        if (character != null)
        {
            oldKnife = knife.GetComponent<ThrowingKnife>();
            Debug.Log("knife??: " + oldKnife);
            newKnife.knives = oldKnife.knives;
            character.SetActive(false);
            Debug.Log("knives from last scene: " + newKnife.knives);
            newInventory.honeycombs = oldInventory.honeycombs;
            Debug.Log("honeycombs from last scene: " + newInventory.honeycombs);
            newInventory.hasHoneycomb = oldInventory.hasHoneycomb;
            Debug.Log("hasHoneycomb from last scene: " + newInventory.honeycombs);
            newInventory.berries = oldInventory.berries;
            Debug.Log("berries from last scene: " + newInventory.berries);
            newInventory.hasBerry = oldInventory.hasBerry;
            Debug.Log("hasBerry from last scene: " + newInventory.berries);
        }
    }
}

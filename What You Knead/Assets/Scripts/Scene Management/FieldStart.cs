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
    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("DarkForestCharacter");
        knife = character.transform.Find("throwing knife");
        Debug.Log("Village boi: " + character);
        if (character != null)
        {
            oldKnife = knife.GetComponent<ThrowingKnife>();
            Debug.Log("knife??: " + oldKnife);
            newKnife.knives = oldKnife.knives;
            character.SetActive(false);
            Debug.Log("knives from last scene: " + newKnife.knives);
        }
    }
}

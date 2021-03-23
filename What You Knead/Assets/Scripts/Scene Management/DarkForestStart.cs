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
    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("ForestCharacter");
        knife = character.transform.Find("throwing knife");
        Debug.Log("Forest boi: " + character);
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

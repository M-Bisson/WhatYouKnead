using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForestStart : MonoBehaviour
{
    private GameObject character;
    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("VillageCharacter");
        SceneManager.MoveGameObjectToScene(character, SceneManager.GetActiveScene());
        Debug.Log("Moved");
        //character = GameObject.Find("VillageCharacter");
        //knife = character.transform.Find("throwing knife");
        //Debug.Log("Village boi: " + character);
        //if (character != null)
        //{
        //    oldKnife = knife.GetComponent<ThrowingKnife>();
        //    Debug.Log("knife??: " + oldKnife);
        //    newKnife.knives = oldKnife.knives;
        //    character.SetActive(false);
        //    Debug.Log("knives from last scene: " + newKnife.knives);
        //}
    }

}

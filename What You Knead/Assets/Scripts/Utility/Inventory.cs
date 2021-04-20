using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject inventoryPanel;
    public GameObject[] inventoryIcons;
    public ThrowingKnife knife;
    public int knives;
    public bool hasKnife;
    public int honeycombs;
    public static bool hasHoneycomb;
    public int berries;
    public static bool hasBerry;
    public int wheat;
    public static bool hasWheat;
    public Player player;


    //------make sure inventory icons get instantiated
    public bool honeyInv;
    public bool knifeInv;
    public bool berryInv;
    public bool wheatInv;

    void Start()
    {

    }

    void Update()
    {

        GameObject i;
        
        if (knives >= 1 && !hasKnife && !knifeInv)
        {
            //Debug.Log("I am what is putting the knife in the inventory");
            knifeInv = true;
            i = Instantiate(inventoryIcons[0]);
            i.transform.SetParent(inventoryPanel.transform);
            hasKnife = true;

            foreach (Transform child in inventoryPanel.transform)
            {
                //if item already in inventory
                if (child.gameObject.tag == "knife")
                {
                    child.Find("Text").GetComponent<Text>().text = "" + knives;
                }
            }
        } else if (knives >= 1) {
            foreach (Transform child in inventoryPanel.transform)
            {
                //if item already in inventory
                if (child.gameObject.tag == "knife")
                {
                    child.Find("Text").GetComponent<Text>().text = "" + knives;
                }
            }
        } else if (knives < 1)
        {
            foreach(Transform child in inventoryPanel.transform)
            {
                //if item already in inventory
                if (child.gameObject.tag == "knife")
                {
                    child.Find("Text").GetComponent<Text>().text = "" + knives;
                }
            }
        }
        //if (knives != knife.knives)
        //{
        //    foreach (Transform child in inventoryPanel.transform)
        //    {
        //        //if item already in inventory
        //        if (child.gameObject.tag == "knife")
        //        {
        //            child.Find("Text").GetComponent<Text>().text = "" + knife.knives;
        //            knives = knife.knives;
        //            return;
        //        }
        //    }
        //}

        if (honeycombs == 1 && !honeyInv)
        {
            i = Instantiate(inventoryIcons[1]);
            i.transform.SetParent(inventoryPanel.transform);
            hasHoneycomb = true;
            honeyInv = true;
        }

        if (berries == 1 && !berryInv)
        {
            i = Instantiate(inventoryIcons[2]);
            i.transform.SetParent(inventoryPanel.transform);
            hasBerry = true;
            berryInv = true;
        }

        if (wheat == 1 && !wheatInv)
        {
            i = Instantiate(inventoryIcons[3]);
            i.transform.SetParent(inventoryPanel.transform);
            hasWheat = true;
            wheatInv = true;
        }

        if(hasBerry && hasHoneycomb && hasWheat)
        {
            player.gotIngredients();
        }

    }


    void OnCollisionEnter(Collision c)
    {

    }


}
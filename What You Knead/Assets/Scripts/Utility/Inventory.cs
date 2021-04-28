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


    ////------make sure inventory icons get instantiated
    //public bool honeyInv;
    //public bool knifeInv;
    //public bool berryInv;
    //public bool wheatInv;

    void Start()
    {

    }

    void Update()
    {

        //GameObject i;

        if (knives >= 1)
        {
            //Debug.Log("I am what is putting the knife in the inventory");
            //knifeInv = true;
            //i = Instantiate(inventoryIcons[0]);
            //i.transform.SetParent(inventoryPanel.transform);
            hasKnife = true;

            foreach (Transform child in inventoryPanel.transform)
            {
                //if item already in inventory
                if (child.gameObject.tag == "knife")
                {
                    child.Find("Text").GetComponent<Text>().text = "" + knives;
                }
            }
        } else if (knives == 0)
        {
            hasKnife = false;

            foreach (Transform child in inventoryPanel.transform)
            {
                //if item already in inventory
                if (child.gameObject.tag == "knife")
                {
                    child.Find("Text").GetComponent<Text>().text = "" + knives;
                }
            }
        }

        if (honeycombs == 1)
        {
            hasHoneycomb = true;
            foreach (Transform child in inventoryPanel.transform)
            {
                //if item already in inventory
                if (child.gameObject.tag == "honeycomb")
                {
                    child.Find("Text").GetComponent<Text>().text = "1";
                }
            }
        } else if (honeycombs == 0)
        {
            hasHoneycomb = false;
            foreach (Transform child in inventoryPanel.transform)
            {
                //if item already in inventory
                if (child.gameObject.tag == "honeycomb")
                {
                    child.Find("Text").GetComponent<Text>().text = "0";
                }
            }
        }

        if (berries == 1)
        {
            hasBerry = true;
            foreach (Transform child in inventoryPanel.transform)
            {
                //if item already in inventory
                if (child.gameObject.tag == "berry")
                {
                    child.Find("Text").GetComponent<Text>().text = "1";
                }
            }
        } else if (berries == 0)
        {
            hasBerry = false;
            foreach (Transform child in inventoryPanel.transform)
            {
                //if item already in inventory
                if (child.gameObject.tag == "berry")
                {
                    child.Find("Text").GetComponent<Text>().text = "0";
                }
            }
        }

        if (wheat == 1)
        {
            hasWheat = true;
            foreach (Transform child in inventoryPanel.transform)
            {
                //if item already in inventory
                if (child.gameObject.tag == "wheat")
                {
                    child.Find("Text").GetComponent<Text>().text = "1";
                }
            }
        } else if (wheat == 0)
        {
            hasWheat = false;
            foreach (Transform child in inventoryPanel.transform)
            {
                //if item already in inventory
                if (child.gameObject.tag == "wheat")
                {
                    child.Find("Text").GetComponent<Text>().text = "0";
                }
            }
        }

        if(hasBerry && hasHoneycomb && hasWheat)
        {
            player.gotIngredients();
        }

    }

}
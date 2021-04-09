using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject inventoryPanel;
    public GameObject[] inventoryIcons;
    public ThrowingKnife knife;
    public int knives = 0;
    public bool hasKnife = false;
    public int honeycombs = 0;
    public bool hasHoneycomb = false;
    public int berries = 0;
    public bool hasBerry = false;
    public int wheat = 0;
    public bool hasWheat = false;

    void Start()
    {
        GameObject i;

        if (knives >= 1 && hasKnife)
        {
            i = Instantiate(inventoryIcons[0]);
            i.transform.SetParent(inventoryPanel.transform);

            foreach (Transform child in inventoryPanel.transform)
            {
                //if item already in inventory
                if (child.gameObject.tag == "knife")
                {
                    child.Find("Text").GetComponent<Text>().text = "" + knives;
                }
            }
        }

        if (honeycombs == 1 && hasHoneycomb)
        {
            i = Instantiate(inventoryIcons[1]);
            i.transform.SetParent(inventoryPanel.transform);
        }

        if (berries == 1 && hasBerry)
        {
            i = Instantiate(inventoryIcons[2]);
            i.transform.SetParent(inventoryPanel.transform);
        }

        if (wheat == 1 && hasWheat)
        {
            i = Instantiate(inventoryIcons[3]);
            i.transform.SetParent(inventoryPanel.transform);
        }

    }

    void Update()
    {
        GameObject i;

        if (knives >= 1 && !hasKnife)
        {
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

        if (honeycombs == 1 && !hasHoneycomb)
        {
            i = Instantiate(inventoryIcons[1]);
            i.transform.SetParent(inventoryPanel.transform);
            hasHoneycomb = true;
        }

        if (berries == 1 && !hasBerry)
        {
            i = Instantiate(inventoryIcons[2]);
            i.transform.SetParent(inventoryPanel.transform);
            hasBerry = true;
        }

        if (wheat == 1 && !hasWheat)
        {
            i = Instantiate(inventoryIcons[3]);
            i.transform.SetParent(inventoryPanel.transform);
            hasWheat = true;
        }

    }


    void OnCollisionEnter(Collision c)
    {
        ////look through children for existing icon
        //foreach(Transform child in inventoryPanel.transform)
        //{
        //    //if item already in inventory
        //    if(child.gameObject.tag == c.gameObject.tag)
        //    {
        //        string s = child.Find("Text").GetComponent<Text>().text;
        //        int tcount = System.Int32.Parse(s) + 1;
        //        child.Find("Text").GetComponent<Text>().text = "" + tcount;
        //        return;
        //    }
        //}

        //GameObject i;
        //if(c.gameObject.tag == "knife")
        //{
        //    i = Instantiate(inventoryIcons[0]);
        //    i.transform.SetParent(inventoryPanel.transform);
        //}
        //if (c.gameObject.tag == "honeycomb")
        //{
        //    i = Instantiate(inventoryIcons[1]);
        //    i.transform.SetParent(inventoryPanel.transform);
        //}
        //if (c.gameObject.tag == "wheat")
        //{
        //    i = Instantiate(inventoryIcons[2]);
        //    i.transform.SetParent(inventoryPanel.transform);
        //}
        //if (c.gameObject.tag == "berry")
        //{
        //    i = Instantiate(inventoryIcons[3]);
        //    i.transform.SetParent(inventoryPanel.transform);
        //}
    }


}
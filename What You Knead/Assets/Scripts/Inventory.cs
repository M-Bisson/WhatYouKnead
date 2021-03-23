using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject inventoryPanel;
    public GameObject[] inventoryIcons;
    public ThrowingKnife knife;
    private int knives = 0;

    private void Update()
    {
        GameObject i;
        //ThrowingKnife knife = character.GetComponent<ThrowingKnife>();
        //Debug.Log("knives: " + knife.knives);
        if (knives != knife.knives && knife.knives == 1)
        {
            i = Instantiate(inventoryIcons[0]);
            i.transform.SetParent(inventoryPanel.transform);
            knives = knife.knives;
        }
        if (knives != knife.knives && knife.knives > 1)
        {
            foreach (Transform child in inventoryPanel.transform)
            {
                //if item already in inventory
                if (child.gameObject.tag == "knife")
                {
                    child.Find("Text").GetComponent<Text>().text = "" + knife.knives;
                    knives = knife.knives;
                    return;
                }
            }
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillageFollowMouse : MonoBehaviour
{

    // Update is called once per frame
    void Update() //https://answers.unity.com/questions/1227892/how-do-i-have-my-character-aim-where-my-mouse-curs.html
    {
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}

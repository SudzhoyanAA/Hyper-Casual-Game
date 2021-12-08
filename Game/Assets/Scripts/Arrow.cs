using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Green")
        {
            Destroy(GameObject.FindGameObjectWithTag("Circle"));
            Destroy(GameObject.FindGameObjectWithTag("Green arrow"));
        }
        else
        {
            Destroy(GameObject.FindGameObjectWithTag("Green arrow"));
        }
    }
}

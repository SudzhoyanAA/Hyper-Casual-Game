using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    //Взаимодействие стрелок с цветами
    void OnTriggerEnter2D(Collider2D col)
    {
        if (this.tag == "Green arrow")
        {
            if (col.gameObject.tag == "Green")
            {
                Destroy(col.transform.parent.gameObject);
                Destroy(GameObject.FindGameObjectWithTag("Green arrow"));
            }
            else
            {
                Destroy(GameObject.FindGameObjectWithTag("Green arrow"));
            }
        }
        else if (this.tag == "Red arrow")
        {
            if (col.gameObject.tag == "Red")
            {
                Destroy(col.transform.parent.gameObject);
                Destroy(GameObject.FindGameObjectWithTag("Red arrow"));
            }
            else
            {
                Destroy(GameObject.FindGameObjectWithTag("Red arrow"));
            }
        }
        else if (this.tag == "Purple arrow")
        {
            if (col.gameObject.tag == "Purple")
            {
                Destroy(col.transform.parent.gameObject);
                Destroy(GameObject.FindGameObjectWithTag("Purple arrow"));
            }
            else
            {
                Destroy(GameObject.FindGameObjectWithTag("Purple arrow"));
            }
        }
        else if (this.tag == "Orange arrow")
        {
            if (col.gameObject.tag == "Orange")
            {
                Destroy(col.transform.parent.gameObject);
                Destroy(GameObject.FindGameObjectWithTag("Orange arrow"));
            }
            else
            {
                Destroy(GameObject.FindGameObjectWithTag("Orange arrow"));
            }
        }
    }
}

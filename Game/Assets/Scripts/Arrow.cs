using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Arrow : MonoBehaviour
{
    public Material blueMaterialRef;

    void FixedUpdate()
    {
        //Замена стрелок на голубые, если уничтожены все кольца
        if (GameObject.Find("Circle").transform.childCount == 1)
        {
            this.GetComponent<Renderer>().material = blueMaterialRef;
            this.tag = "Blue arrow";
        }
    }

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
        if (this.tag == "Blue arrow")
        {
            Debug.Log("Победа!");
            Destroy(GameObject.FindGameObjectWithTag("Blue arrow"));
            SceneManager.LoadScene(2);
        }
    }
}

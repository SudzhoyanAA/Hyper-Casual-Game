using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }

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

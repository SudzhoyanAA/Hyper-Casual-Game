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
        Destroy(GameObject.FindGameObjectWithTag("Circle"));
        Destroy(GameObject.FindGameObjectWithTag("Arrow"));
    }
}

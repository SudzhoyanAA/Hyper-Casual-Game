using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    //public float force;
    public GameObject arrowPrefab;
    GameObject arrow;

    public float repeat_time;
    private float curr_time;

    public float speed;

    void Start()
    {
        arrow = Instantiate(arrowPrefab, transform);
        curr_time = repeat_time;
    }

    void FixedUpdate()
    {
        curr_time -= Time.deltaTime;

        if (curr_time <= 0)
        {
            arrow = Instantiate(arrowPrefab, transform);
            curr_time = repeat_time;
        }

        if (GameObject.FindGameObjectWithTag("Green arrow") != null)
        {
            //arrow.transform.parent = null;
            //arrow.GetComponent<Rigidbody2D>().AddForce(Vector2.up * force, ForceMode2D.Impulse);
            arrow.GetComponent<Rigidbody2D>().velocity = new Vector3(-12, 5, 0) * speed;
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float force;
    public GameObject arrowPrefab;
    GameObject arrow;

    public float repeat_time; 
    private float curr_time;
    
    void Start()
    {
        arrow = Instantiate(arrowPrefab, transform);
        curr_time = repeat_time * 1000f;
    }
    void Update()
    {
        curr_time -= Time.deltaTime;
        if (curr_time <= 0)
        {
            arrow = Instantiate(arrowPrefab, transform);
            curr_time = repeat_time * 1000f;
        }
    }   
    void FixedUpdate()
    {
        arrow.transform.parent = null;
        arrow.GetComponent<Rigidbody2D>().AddForce(Vector2.up * force, ForceMode2D.Impulse);
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

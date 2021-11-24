using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] KeyCode keyOne;
    [SerializeField] KeyCode keyTwo;
    public float speed;

    private void FixedUpdate()
    {
        if (Input.GetKey(keyOne))
        {
            transform.Rotate(0, 0, speed);
        }
        if (Input.GetKey(keyTwo))
        {
            transform.Rotate(0, 0, -speed);
        }
    }
}

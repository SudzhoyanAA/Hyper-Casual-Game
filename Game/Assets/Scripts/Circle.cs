using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] KeyCode key;
    public float speed;

    private void FixedUpdate()
    {
        if (Input.GetKey(key))
        {
            transform.Rotate(0, 0, -speed);
        }
    }
}

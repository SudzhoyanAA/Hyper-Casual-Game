using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] KeyCode key;

    private float speed = 0.05f;
    private float speedIncrease = 0f;

    private void FixedUpdate()
    {
        if (Input.GetKey(key))
        {
            switch (GameObject.Find("Circle").transform.childCount)
            {
                case 8:
                    GameObject.Find("Circle").transform.GetChild(0).transform.Rotate(0, 0, -speed);
                    break;
                case 7:
                    GameObject.Find("Circle").transform.GetChild(0).transform.Rotate(0, 0, -(speed + 0.05f));
                    break;
                case 6:
                    GameObject.Find("Circle").transform.GetChild(0).transform.Rotate(0, 0, -(speed + 0.1f));
                    break;
                case 5:
                    GameObject.Find("Circle").transform.GetChild(0).transform.Rotate(0, 0, -(speed + 0.2f));
                    break;
                case 4:
                    GameObject.Find("Circle").transform.GetChild(0).transform.Rotate(0, 0, -(speed + 0.45f));
                    break;
                case 3:
                    GameObject.Find("Circle").transform.GetChild(0).transform.Rotate(0, 0, -(speed + 0.8f));
                    break;
                case 2:
                    GameObject.Find("Circle").transform.GetChild(0).transform.Rotate(0, 0, -(speed + 1f));
                    break;
            }

            for (int i = 0; i < GameObject.Find("Circle").transform.childCount; i++)
            {
                speedIncrease += 0.1f;
                GameObject.Find("Circle").transform.GetChild(i).transform.Rotate(0, 0, -(speed + speedIncrease));
            }
            speedIncrease = 0f;
        }
    }
}

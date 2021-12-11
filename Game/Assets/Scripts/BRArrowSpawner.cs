using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BRArrowSpawner : MonoBehaviour
{
    public GameObject arrowPrefab;
    GameObject arrow;

    private float timer = 0;
    public float start_delay;
    public float timing;

    public float speed;

    void Start()
    {
        //Первая генерация стрелки с определенной задержкой
        Invoke("ArrowInstantiate", start_delay);
    }

    void FixedUpdate()
    {
        //Последующие генерации срелки с определенным интервалом 
        timer += Time.deltaTime;
        if (timer >= timing)
        {
            Invoke("ArrowInstantiate", start_delay);
            timer = 0;
        }
        //Движение стрелки
        if (GameObject.FindGameObjectWithTag("Green arrow") != null)
        {
            arrow.GetComponent<Rigidbody2D>().velocity = new Vector3(Screen.width / -2, Screen.height / 2, 0) * speed;
        }
    }

    void ArrowInstantiate()
    {
        //Рассчет позиции угла экрана
        Bounds bounds = GetComponent<SpriteRenderer>().bounds;
        Vector3 bottomLeftPosition = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth, 0, Camera.main.nearClipPlane));
        bottomLeftPosition += new Vector3(bounds.size.x / 2, -bounds.size.y / 2, 0);
        //Генерация стрелки в этой позиции
        arrow = Instantiate(arrowPrefab, bottomLeftPosition, Quaternion.Euler(0, 0, -35));
    }
}


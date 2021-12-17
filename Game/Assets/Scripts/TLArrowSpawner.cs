using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TLArrowSpawner : MonoBehaviour
{
    public GameObject arrowPrefab;
    GameObject arrow;

    private float timer = 0;
    public float start_delay;
    public float timing;

    public float speed;

    Material[] colors = new Material[4];
    public Material greenMaterialRef;
    public Material redMaterialRef;
    public Material purpleMaterialRef;
    public Material orangeMaterialRef;

    void Start()
    {
        colors[0] = greenMaterialRef;
        colors[1] = redMaterialRef;
        colors[2] = purpleMaterialRef;
        colors[3] = orangeMaterialRef;

        //Первая генерация стрелки с определенной задержкой
        Invoke("ArrowInstantiate", start_delay);
    }

    void FixedUpdate()
    {
        //Последующие генерации срелки с определенным интервалом
        timer += Time.deltaTime;
        if (timer >= timing)
        {
            speed += 0.003F;
            Invoke("ArrowInstantiate", start_delay);
            timer = 0;
        }
        //Движение стрелки
        if (arrow != null)
        {
            arrow.GetComponent<Rigidbody2D>().velocity = new Vector3(Screen.width / 2, Screen.height / -2, 0) * speed;
        }
    }

    void ArrowInstantiate()
    {
        //Рассчет позиции угла экрана
        Bounds bounds = GetComponent<SpriteRenderer>().bounds;
        Vector3 topLeftPosition = Camera.main.ScreenToWorldPoint(new Vector3(0, Camera.main.pixelHeight, Camera.main.nearClipPlane));
        topLeftPosition += new Vector3(bounds.size.x / 2, -bounds.size.y / 2, 0);
        //Генерация стрелки в этой позиции
        arrow = Instantiate(arrowPrefab, topLeftPosition, Quaternion.Euler(0, 0, -35));

        //Рандомное присваивание цвета стрелке
        arrow.GetComponent<Renderer>().material = colors[Random.Range(0, colors.Length)];
        //Присваивание соответствующего тега стрелке
        if (arrow.GetComponent<Renderer>().sharedMaterial == redMaterialRef)
        {
            arrow.tag = "Red arrow";
        }
        else if (arrow.GetComponent<Renderer>().sharedMaterial == purpleMaterialRef)
        {
            arrow.tag = "Purple arrow";
        }
        else if (arrow.GetComponent<Renderer>().sharedMaterial == orangeMaterialRef)
        {
            arrow.tag = "Orange arrow";
        }
    }
}


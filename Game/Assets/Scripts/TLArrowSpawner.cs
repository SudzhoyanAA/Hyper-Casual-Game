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

        //������ ��������� ������� � ������������ ���������
        Invoke("ArrowInstantiate", start_delay);
    }

    void FixedUpdate()
    {
        //����������� ��������� ������ � ������������ ����������
        timer += Time.deltaTime;
        if (timer >= timing)
        {
            speed += 0.003F;
            Invoke("ArrowInstantiate", start_delay);
            timer = 0;
        }
        //�������� �������
        if (arrow != null)
        {
            arrow.GetComponent<Rigidbody2D>().velocity = new Vector3(Screen.width / 2, Screen.height / -2, 0) * speed;
        }
    }

    void ArrowInstantiate()
    {
        //������� ������� ���� ������
        Bounds bounds = GetComponent<SpriteRenderer>().bounds;
        Vector3 topLeftPosition = Camera.main.ScreenToWorldPoint(new Vector3(0, Camera.main.pixelHeight, Camera.main.nearClipPlane));
        topLeftPosition += new Vector3(bounds.size.x / 2, -bounds.size.y / 2, 0);
        //��������� ������� � ���� �������
        arrow = Instantiate(arrowPrefab, topLeftPosition, Quaternion.Euler(0, 0, -35));

        //��������� ������������ ����� �������
        arrow.GetComponent<Renderer>().material = colors[Random.Range(0, colors.Length)];
        //������������ ���������������� ���� �������
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


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRArrowSpawner : MonoBehaviour
{
    public GameObject arrowPrefab;
    GameObject arrow;

    private float timer = 0;
    public float start_delay;
    public float timing;

    public float speed;
    public float scale;

    Vector3 screenCenter;

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
        //������� ������� ������ ������
        screenCenter = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 10f));
        //������ ��������� ������� � ������������ ���������
        Invoke("ArrowInstantiate", start_delay);
    }

    void FixedUpdate()
    {
        //����������� ��������� ������ � ������������ ����������
        timer += Time.deltaTime;
        if (GameObject.FindGameObjectsWithTag("Green arrow").Length == 0 && GameObject.FindGameObjectsWithTag("Red arrow").Length == 0 && GameObject.FindGameObjectsWithTag("Purple arrow").Length == 0 && GameObject.FindGameObjectsWithTag("Orange arrow").Length == 0 && timer >= 1)
        {
            speed += 0.08F;
            Invoke("ArrowInstantiate", 3);
            timer = 0;
        }
        //�������� �������
        if (arrow != null)
        {
            arrow.transform.position = Vector3.MoveTowards(arrow.transform.position, screenCenter, speed);
        }
    }

    void ArrowInstantiate()
    {
        //������� ������� ���� ������
        Bounds bounds = GetComponent<SpriteRenderer>().bounds;
        Vector3 topRightPosition = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth, Camera.main.pixelHeight, Camera.main.nearClipPlane));
        topRightPosition += new Vector3(bounds.size.x / 2, -bounds.size.y / 2, 0);
        //��������� ������� � ���� �������
        arrow = Instantiate(arrowPrefab, topRightPosition, Quaternion.Euler(0, 0, 35));

        //��������� ������� �������
        arrow.transform.localScale = new Vector3(scale, scale, scale);
        scale -= 0.2f;

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


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public GameObject[] list = new GameObject[2];
    LineRenderer lineRenderer;
    bool isLine;


    // Start is called before the first frame update
    void Start()
    {
        isLine = false;
        lineRenderer = gameObject.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("LineFun", 0.1f, 0.1f);
    }

    void LineFun()
    {
        List<Vector3> vecList = new List<Vector3>();
        for (int i = 0; i < list.Length; i++)
        {
            vecList.Add(gameObject.transform.position);
            vecList.Add(list[i].transform.position);
        }

        lineRenderer.positionCount = vecList.Count;
        lineRenderer.SetPositions(vecList.ToArray());

    }
}

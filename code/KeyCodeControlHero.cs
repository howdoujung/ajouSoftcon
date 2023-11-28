using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCodeControlHero : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public LineRenderer lineRenderer2;

    bool isFog;
    bool isLine;
    // Start is called before the first frame update
    void Start()
    {
        isLine = false;
        isFog = false;
        RenderSettings.fog = false;
        lineRenderer.enabled = false;
        lineRenderer2.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;   
        if (Input.GetKeyDown(KeyCode.F))
        {
            isFog = !isFog;
            if (isFog)
            {
                RenderSettings.fog = false;
            }
            else
            {
                ThirdPersonController.MoveSpeed = 1.5f;
                RenderSettings.fog = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            isLine = !isLine;
            if (isLine)
            {
                lineRenderer.enabled = false;
                lineRenderer2.enabled = false;
            }
            else
            {
                lineRenderer.enabled = true;
                lineRenderer2.enabled = true;
            }
        }
    }
}

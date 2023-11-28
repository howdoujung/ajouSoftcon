using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public Camera heroCamera;
    public Camera CCTVCamera;

    // Call this function to disable FPS camera,
    // and enable overhead camera.
    public void ShowCCTVView()
    {
        heroCamera.enabled = false;
        CCTVCamera.enabled = true;
    }

    // Call this function to enable FPS camera,
    // and disable overhead camera.
    public void ShowHeroView()
    {
        heroCamera.enabled = true;
        CCTVCamera.enabled = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

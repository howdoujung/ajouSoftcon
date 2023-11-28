using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniMapFog_Off : MonoBehaviour
{
    private bool savedFogState;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnPreRender()
    {
        savedFogState = RenderSettings.fog;
        RenderSettings.fog = false;
    }

    void OnPostRender()
    {
        RenderSettings.fog = savedFogState;
    }
}

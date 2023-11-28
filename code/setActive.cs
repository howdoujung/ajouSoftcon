using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setActive : MonoBehaviour
{
    public GameObject activeUI;
    public GameObject activeMinimap;
    public GameObject activeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        activeUI.SetActive(true);
    }

    public void OnClick()
    {
        Destroy(activeUI);
        activeMinimap.SetActive(true);
        activeText.SetActive(true);
    }
}

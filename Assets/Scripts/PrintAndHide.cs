using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update
    private int frameCount = 4;
    public Renderer rend;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"{gameObject.name}:{frameCount}");
        frameCount++;

        if ( frameCount > 6)
        {
            rend.enabled = false;
        }
    }
}

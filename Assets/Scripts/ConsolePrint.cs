using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    // Start is called before the first frame update
    private int frameCount = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"GameObject's name: {gameObject.name}:{frameCount}");
    }
}

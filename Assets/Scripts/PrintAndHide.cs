using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update
    private int frameCount = 4;
    public int i=200;
    public Renderer rend;
    public int random;
    void Start()
    {    

        random = Random.Range(150,251);
        i= random;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"{gameObject.name}:{frameCount}");
        frameCount++;

        if (frameCount > 6)
        {
            rend.enabled = false;
        }

        if (gameObject.CompareTag("Red"))
        {
            // If the tag is "Red" and i equals 100, deactivate the game object
            if (i == 100)
                gameObject.SetActive(false);
        }
        if (gameObject.CompareTag("Blue"))
        {
            if (i >= 150 && i <= 250)
                rend.enabled = false;
        }
        i++;
    }

}

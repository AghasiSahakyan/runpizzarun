using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject movingPlatform;
    private MovingPlatform moveScript;
    private bool scriptOn;

    // Start is called before the first frame update
    void Start()
    {
        moveScript = movingPlatform.GetComponent<MovingPlatform>();
        moveScript.enabled = false;
        scriptOn = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !scriptOn)
        {
            moveScript.enabled = true;
            scriptOn = true;
        }
        else if (other.CompareTag("Player") && scriptOn)
        {
            moveScript.enabled = false;
            scriptOn = false;
        }
    }
}

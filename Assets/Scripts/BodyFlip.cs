using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyFlip : MonoBehaviour
{
    public Transform startPos;
    public GameObject handLeft, handRight, legLeft, legRight;
    private float moveInput;
    private float speed = 20f;

    private void Start()
    {
        transform.position = startPos.position;
    }

    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal") * speed;
        if (moveInput > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (moveInput < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (moveInput == 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}

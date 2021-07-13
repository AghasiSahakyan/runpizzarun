using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsPosition : MonoBehaviour
{
    public Transform startPos;

    private void Start()
    {
        transform.position = startPos.position;
    }
}

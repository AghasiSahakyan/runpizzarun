using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform targetPlayer;
    public Vector3 offset;
    [Range(1, 10)]
    public float smoothMove;

    private void FixedUpdate()
    {
        Vector3 targetPos = targetPlayer.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, targetPos, smoothMove * Time.fixedDeltaTime);
        transform.position = smoothPos;
    }
}

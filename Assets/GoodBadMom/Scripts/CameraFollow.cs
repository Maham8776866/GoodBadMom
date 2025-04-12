using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;
    public Vector3 offset;

    public float smoothSpeed = 0.1f;
    private void LateUpdate()
    {
        Vector3 desiredposition = Player.position + offset;
        Vector3 smoothedposition = Vector3.Lerp(transform.position, desiredposition, smoothSpeed);
        transform.position = new Vector3(0f, smoothedposition.y, smoothedposition.z);

    }
}

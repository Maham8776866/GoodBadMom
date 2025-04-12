using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;


 public float smoothSpeed = 0.1f;
 


    void LateUpdate()
    {

        Vector3 desiredPosition = player.position + offset;

       Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
      
        transform.position = new Vector3(0f, smoothedPosition.y, smoothedPosition.z);
     
    }



}

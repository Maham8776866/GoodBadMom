using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController characterController;
    public float forwardSpeed = 2;
    public float horizontalSpeed = 3;

    void Update()
    {
        float InputX = Input.GetAxis("Horizontal");
        Vector3 forwardMove = transform.forward * forwardSpeed * Time.deltaTime;
        Vector3 movement = new Vector3(InputX, 0, 0) * horizontalSpeed * Time.deltaTime;
        Vector3 move = movement + forwardMove;
        characterController.Move(move);
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    public CharacterController characterController;
    public float forwardSpeed = 5;
    public float horizontalSpeed = 6;
  void Update()
    {
        float InputX = Input.GetAxis("Horizontal");

        Vector3 forwardMove = transform.forward * forwardSpeed * Time.deltaTime;
        Vector3 movement = new Vector3(InputX, 0, 0) * horizontalSpeed * Time.deltaTime;
        Vector3 move = forwardMove + movement;
        characterController.Move(move);

    }

    /*  public float forwardspeed =5;
   *//*   public Rigidbody rb;*//*
     public Animator animator;
      public float horizontalspeed = 6;
      public CharacterController characterController;
      void Update()
      {

          float inputX = Input.GetAxis("Horizontal");





          Vector3 forwardMove = transform.forward * forwardspeed * Time.deltaTime;


        //  characterController.Move(forwardMove);
          *//*    rb.MovePosition(rb.position + forwardMove); *//*


          Vector3 movement = new Vector3(inputX, 0, 0) * horizontalspeed * Time.deltaTime;

          Vector3 move = forwardMove + movement;

          characterController.Move(move);


      }*/
}

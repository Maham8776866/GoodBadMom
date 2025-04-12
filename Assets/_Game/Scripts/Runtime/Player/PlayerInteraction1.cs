using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction1 : MonoBehaviour
{
    public UIScreen uiScreen;
    public UIScore uIScore;
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Coin"))
        {
            uIScore.CoinsAdded();
            other.gameObject.SetActive(false);
        }

        if(other.CompareTag("Finishline"))
        {
            uiScreen.winning();
            uiScreen.stopTime();
        }

        if(other.CompareTag("deathcollider"))
        {
            uiScreen.losing(); 
        }
    }

    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("im colliding");
            uiScreen.losing();
            uiScreen.stopTime();
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("im colliding");
            uiScreen.losing();
            uiScreen.stopTime();
        }
        
    }

    /*  public void OnCollisionEnter(Collision collision)
      {
          if (collision.gameObject.CompareTag("object")) ;
          { Debug.Log("im colliding"); }
      }*/

}

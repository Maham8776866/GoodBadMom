using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    /*    public void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Cash"))
            {
                other.gameObject.SetActive(false);
                Debug.Log("im triggering");
            }
        }*/
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cash"))
        {
            
            other.gameObject.SetActive(false);
            Debug.Log("im triggering");
        }

      
    }
}

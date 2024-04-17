using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sript : MonoBehaviour
{
  // OnTriggerEnter is called when the collider other enters the trigger 
  void OntriggerEnter(Collider other)
    {
        if (other.CompareTag("target"))

                 Destroy(gameObject);
    }
    //destroy the ball

    
}

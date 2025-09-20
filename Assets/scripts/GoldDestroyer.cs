using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldDestroyer : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Destroyer")) 
        {
            Destroy(gameObject); 
        }
    }
}

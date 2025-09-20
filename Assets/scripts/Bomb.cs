using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Destroyer")) 
        {
            Destroy(gameObject); 
        }
        else if (other.CompareTag("Player")) 
        {
            AudioManager.Instance.PlayBombFailSound();
            FindObjectOfType<HealthManager>().TakeDamage();
            Destroy(gameObject); 
        }
    }
}

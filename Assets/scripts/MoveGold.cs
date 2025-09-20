using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGold : MonoBehaviour
{
    public float speed = 10f;  
    public float minZ = -10f; 

    void Update()
    {      
        if (transform.position.z > minZ)
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
    }
}

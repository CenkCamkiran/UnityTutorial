using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public SphereMovement sphereMovement;

    void OnCollisionEnter(Collision collision)
    {
        //if (collision.collider.name == "Obstacle")
        //    Debug.Log(collision.collider.name);

        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log(collision.collider.name);
            sphereMovement.enabled = false;
        }
            
    }
}

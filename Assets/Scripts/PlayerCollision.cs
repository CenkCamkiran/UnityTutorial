using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //public GameManager gameManager; //Variable ile yap�lan 1. y�ntem
    //public GameManager gameManager;
    public SphereMovement sphereMovement;

    void OnCollisionEnter(Collision collision)
    {
        //if (collision.collider.name == "Obstacle")
        //    Debug.Log(collision.collider.name);

        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log(collision.collider.name);
            GetComponent<SphereMovement>().enabled = false;
            //sphereMovement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            //gameManager.EndGame();
        }
            
    }
}

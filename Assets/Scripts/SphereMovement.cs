using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game has started...");

        //rb.AddForce(0, 0, 2000f * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {

        //drag deðiþkeni, havaya karþý direnci gösteriyor.
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //ignores mass

        if (Input.GetKey(KeyCode.A))
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //ignores mass

        if (Input.GetKey(KeyCode.W))
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
            rb.AddForce(0, 850 * Time.deltaTime, 0);

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }

    void FixedUpdate()
    {
        
    }
}

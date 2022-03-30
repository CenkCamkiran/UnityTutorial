using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game has started...");

        //rb.AddForce(0, 0, 2000f * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
            rb.AddForce(500 * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.A))
            rb.AddForce(-500 * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.W))
            rb.AddForce(0, 0, 500 * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            rb.AddForce(0, 0, -500 * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
            rb.AddForce(0, 850 * Time.deltaTime, 0);


    }

    void FixedUpdate()
    {
        
    }
}

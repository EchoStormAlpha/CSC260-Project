using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


    public Rigidbody rb;
    private float forwardForce = 13000f;
    private float lateralForce = 13000f;
    private int jumptime = 100;

	void FixedUpdate()
    {
        if(Input.GetKey("w"))
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("a"))
            rb.AddForce(-lateralForce * Time.deltaTime,0, 0);
        if (Input.GetKey("s"))
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
            rb.AddForce(lateralForce * Time.deltaTime, 0,  0);
        if (Input.GetKey("v") && jumptime>0)
            rb.AddForce(0, 1000, 0);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets
{
    public class PlayerMovement : MonoBehaviour//Class is focused on allowing movement
    {


        public Rigidbody rb;
        private float forwardForce = 16000f;
        private float lateralForce = 16000f;
        private int jumptime = 100;
       
        void FixedUpdate()
        {
            if (Input.GetKey("w"))/////////////////////////////////////Allows 5 types of movement
                rb.AddForce(0, 0, forwardForce * Time.deltaTime);
            if (Input.GetKey("a"))
                rb.AddForce(-lateralForce * Time.deltaTime, 0, 0);
            if (Input.GetKey("s"))
                rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
            if (Input.GetKey("d"))
                rb.AddForce(lateralForce * Time.deltaTime, 0, 0);
            if (Input.GetKey("v") && jumptime > 0)
            {
                rb.AddForce(0, 1000, 0);
                jumptime = jumptime - 25;
            }
            jumptime = jumptime + 4;

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormsController : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public float moveForce;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 force = new Vector3(0,jumpForce,0);
            
            rb.AddForce(force);
            Debug.Log("Got Key Down");
        }
        if (Input.GetKey(KeyCode.D))
        {

            Vector3 keyd = new Vector3(moveForce, 0, 0);

            rb.AddForce(keyd);
            Debug.Log("Got Key D");
        }

        if (Input.GetKey(KeyCode.A))
        {

            Vector3 keya = new Vector3(-moveForce, 0, 0);

            rb.AddForce(keya);
            Debug.Log("Got Key A");
        }
    }
}

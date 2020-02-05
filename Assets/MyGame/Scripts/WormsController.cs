using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormsController : MonoBehaviour
{
    public Rigidbody rbAmmo;
    public Rigidbody rb;
    public float jumpForce;
    public float moveForce;
    public float AmmoForce;


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
        if (Input.GetKeyDown(KeyCode.P))
        {
            Rigidbody clone;
           
            Vector3 fix = new Vector3(0.5f, 0.5f, 0f);
            clone = Instantiate(rbAmmo,transform.position + fix, transform.rotation);
            clone.velocity = transform.TransformDirection(AmmoForce, 0f, 0f);

            Vector3 keyp = new Vector3(AmmoForce, 0, 0);
            rbAmmo.AddForce(keyp);


            
        }
    }
}

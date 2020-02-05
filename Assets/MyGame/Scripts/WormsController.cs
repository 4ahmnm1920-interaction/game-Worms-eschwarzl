using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormsController : MonoBehaviour
{
    public Rigidbody rbAmmo;
    public Rigidbody rb;
    public Rigidbody rb2;
    public float jumpForce;
    public float moveForce;
    public float AmmoForce;
    public KeyCode ShootKey;
    public KeyCode negativeShootKey;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 force = new Vector3(0, jumpForce, 0);

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
        if (Input.GetKeyDown(ShootKey))
        {
            Rigidbody clone;

            Vector3 fix = new Vector3(0.5f, 0.5f, 0f);
            clone = Instantiate(rbAmmo, transform.position + fix, transform.rotation);
            clone.velocity = transform.TransformDirection(AmmoForce, 0f, 0f);

            Vector3 keyr = new Vector3(AmmoForce, 0, 0);
            rbAmmo.AddForce(keyr);
        }

        if (Input.GetKeyDown(negativeShootKey))
        {
            Rigidbody clone;

            Vector3 fix = new Vector3(-0.5f, 0.5f, 0f);
            clone = Instantiate(rbAmmo, transform.position + fix, transform.rotation);
            clone.velocity = transform.TransformDirection(-AmmoForce, 0f, 0f);

            Vector3 keyr = new Vector3(-AmmoForce, 0, 0);
            rbAmmo.AddForce(keyr);
        }


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 force2 = new Vector3(0, jumpForce, 0);

            rb2.AddForce(force2);
            Debug.Log("Got Key Down");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {

            Vector3 keyright = new Vector3(moveForce, 0, 0);

            rb2.AddForce(keyright);
            Debug.Log("Got Key D");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            Vector3 keyleft = new Vector3(-moveForce, 0, 0);

            rb2.AddForce(keyleft);
            Debug.Log("Got Key A");

        }



    }
}

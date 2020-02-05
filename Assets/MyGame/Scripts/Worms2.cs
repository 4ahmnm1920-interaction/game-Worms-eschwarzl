using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worms2 : MonoBehaviour
{
    public Rigidbody rb2;
    public float jumpForce;
    public float moveForce;
    public float AmmoForce;
    public Rigidbody rbAmmo2;


    // Update is called once per frame
    void Update()
    {
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

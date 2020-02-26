using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    public WormsController worm;
    public float newAmmoForce;



    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collisiannnn");

        if (other.gameObject.tag == "Player")
        {
            worm = other.gameObject.GetComponent<WormsController>();
            worm.AmmoForce = newAmmoForce;

            other.gameObject.GetComponent<Rigidbody>().useGravity = false; ;
            

            Destroy(this.gameObject);
        }
    }
}

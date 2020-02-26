using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSpawner : MonoBehaviour
{
    public int anzahl;
    public GameObject PickUp;
    public Vector3 start;
    public Vector3 End;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < anzahl; i++)
        {
            Debug.Log("Wird ausgeführt");

            float x = Random.Range(start.x,End.x);
            float y = Random.Range(start.y,End.y);
            float z = Random.Range(start.z,End.z); ;

            Instantiate(PickUp, new Vector3(x, y, z), Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTeleport : MonoBehaviour
{
    
    public Transform doorTwo;
    public bool working;

    public GameObject doorOne;
    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        //example 1
        if (collision.gameObject == doorOne)
        {
            working = true;
            transform.position = doorTwo.transform.position;
        }

    }
}

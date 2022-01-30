using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncePad : MonoBehaviour
{
    public Rigidbody rb;
    public bool bouncing;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(bouncing == true)
        {
            Bounce();
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "bounce")
        {
            bouncing = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.collider.tag == "bounce")
        {
            bouncing = false;
        }
    }

    void Bounce()
    {
        rb.AddForce(new Vector3(0f, 1000f, 0f * Time.deltaTime), ForceMode.Force);
    }

}

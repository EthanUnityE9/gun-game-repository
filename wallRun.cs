using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallRun : MonoBehaviour
{
    public Rigidbody rb;
    public LayerMask maskLeft;
    public LayerMask maskRight;
    public bool IsOnLeft;
    public bool IsnotOnWall;
    public float forwardForce;
    public float downForce;
    // Start is called before the first frame update
    void Start()
    {
        IsnotOnWall = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsOnLeft == true && IsnotOnWall == false)
        {
            WallrunLeft();
            rb.useGravity = false;
        }

        else
        {
            rb.useGravity = true;
        }

        if (IsOnLeft == false && IsnotOnWall == false)
        {
            WallrunRight();
            rb.useGravity = false;
        }

        else
        {
            rb.useGravity = true;
        }

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "leftWall")
        {
            IsOnLeft = true;
            IsnotOnWall = false;
        }

        if (other.collider.tag == "rightWall")
        {
            IsOnLeft = false;
            IsnotOnWall = false;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.collider.tag == "leftWall")
        {
            IsnotOnWall = true;
            IsOnLeft = false;
        }

        if (other.collider.tag == "rightWall")
        {
            IsnotOnWall = true;
            IsOnLeft = false;
        }
    }

    void WallrunLeft()
    {
        print("starting left wall run");
    }

    void WallrunRight()
    {
        print("starting Right wall run");
        rb.AddForce(transform.forward * forwardForce);
        rb.AddForce(-transform.up * downForce);
    }
}

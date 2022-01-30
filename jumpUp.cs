using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpUp : MonoBehaviour
{
    
    [Header("References")]
    [Tooltip("Reference to the main camera used for the player")]

    public Rigidbody rbb;
    public AudioSource jumpSFX;
    public LayerMask mask;

    [Header("Jump")]
    [Tooltip("bool  isGrounded")]
    public bool isGrounded;




    void Start()
    {
        rbb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
          if(isGrounded){
              //jump
            rbb.AddForce(new Vector3(0f, 550f, 0f), ForceMode.Force);
            jumpSFX.Play();
          }
      }
    }


    void OnCollisionEnter(Collision other)
    {
        if ((mask.value & 1 << other.gameObject.layer) == 1 << other.gameObject.layer)
        {// this says if the player collides with the bat do blank
            

                isGrounded = true;

            
        }
    }

    void OnCollisionExit(Collision other)
    {
        if ((mask.value & 1 << other.gameObject.layer) == 1 << other.gameObject.layer)
        {

            isGrounded = false;

        }
    }
}  
    


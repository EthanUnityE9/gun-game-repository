using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

[RequireComponent(typeof(AudioSource))]
public class playerMovmentNetcode : NetworkBehaviour

{

    
    [Header("References")] [Tooltip("Reference to the main camera used for the player")]


    public AudioSource walk;
    public Rigidbody rb;
    public GameObject self;


    // Headers make a little header pop up in the inspector bascily seperating things

    [Header("Public Ints")] [Tooltip("Used for spped of the player")]
    public float walkSpeed;
    public float sidewaysSpeed;

    float x;
    float y;
    float z;
    Vector3 pos;

    [Header("Public Ints")] [Tooltip("Used for spped of the player")]
    //wallrun things

    
    public AudioSource jumpSFX;
    public LayerMask mask;

    [Header("Jump")]
    [Tooltip("bool  isGrounded")]
    public bool isGrounded;

    // vector3 velocity just adds a vector 3 that stors velocity of the player
    Vector3 velocity;
    //Vector3 magnitued;

    void Start()
    {
        Physics.gravity = new Vector3(0, -10, 0);

        x = Random.Range(4, 4);
        y = 5;
        z = Random.Range(-4, -4);
        pos = new Vector3(x, y, z);
        transform.position = pos;

    }

    // Update is called once per frame

    private void Update()
    {
        if (IsLocalPlayer)
        {
            Movment();
        }

        
    }


    

    public void Movment()
    { 

         

// these 4 lines are saying to get a axis move the way its told (in Vector3.forward or left) * the speed that is discribed above
float forwardMovement = Input.GetAxis("Vertical") * walkSpeed * Time.deltaTime;
        float sideWaysMovement = Input.GetAxis("Horizontal") * sidewaysSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Translate(Vector3.right * sideWaysMovement);

        

        // sound effects for the movment above
        if(Input.GetKeyDown(KeyCode.W) | Input.GetKeyDown(KeyCode.A) | Input.GetKeyDown(KeyCode.S) | Input.GetKeyDown(KeyCode.D))
        {
            // the | in the line above is basicilcly saying or
            
                walk.Play();
            
        }
        //jump

       
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (isGrounded)
                {
                    
                    //jump
                    rb.AddForce(new Vector3(0f, 550f, 0f * Time.deltaTime), ForceMode.Force);
                    jumpSFX.Play();
                    
                }
            }

        

        if (Input.GetKeyDown(KeyCode.Q))
        {
            walkSpeed = 15f;

            //this ajusts speed if blank is pushed
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

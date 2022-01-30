using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class playerMovment : MonoBehaviour
{
    [Header("References")] [Tooltip("Reference to the main camera used for the player")]
    
    
    public AudioSource walk;
    public Rigidbody rb;
    public GameObject self;
    

    // Headers make a little header pop up in the inspector bascily seperating things
    
    [Header("Public Ints")] [Tooltip("Used for spped of the player")]
    public float walkSpeed;
    public float sidewaysSpeed;

    [Header("Public Ints")] [Tooltip("Used for spped of the player")]
    //wallrun things
   

    // vector3 velocity just adds a vector 3 that stors velocity of the player
    Vector3 velocity;
    //Vector3 magnitued;

    void Start()
    {
        Physics.gravity = new Vector3(0, -10, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // this asigns a variable named movment to the player
        Movment();
        



    }

    void Movment()
    {
        rb.AddForce(Vector3.down * Time.deltaTime * 10);
        // these 4 lines are saying to get a axis move the way its told (in Vector3.forward or left) * the speed that is discribed above
        float forwardMovement = Input.GetAxis("Vertical") * walkSpeed * Time.deltaTime;
        float sideWaysMovement = Input.GetAxis("Horizontal") * sidewaysSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Translate(Vector3.right * sideWaysMovement);

        

        // sound effects for the movment above
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            // the || in the line above is basicilcly saying or
            
                walk.Play();
            
        }
        //jump
        
        
        
        if(Input.GetKeyDown(KeyCode.Q))
        {
            walkSpeed = 15f;

            //this ajusts speed if blank is pushed
        }
    }
           

       

}

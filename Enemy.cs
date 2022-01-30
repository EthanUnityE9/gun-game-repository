using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float turnspeed;
    public float angleamountturn = 20f;
    Transform player;
    public float speed;
    public bool gotem;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        print("Looking For Player");

        gotem = true;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (gotem == true)
        {
            spin();
        }

        else
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            transform.LookAt(player.gameObject.transform.position);

        }

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            if (hit.collider.gameObject.tag == "Player")
            {
                gotem = false;

            }

        }
    }
    
    public void spin()
    {
        transform.Rotate(new Vector3(0, angleamountturn, 0) * turnspeed * Time.deltaTime);
    }
    

    
        
    
}

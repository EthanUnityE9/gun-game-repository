using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatboi : MonoBehaviour
{
    public Transform player;
    
    public float speed;
    public float smooth = 5.0f;
    private void Update()
    {
        MoveToPlayer();
    }
    // Update is called once per frame
    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        
    }
}

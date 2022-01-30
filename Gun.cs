using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gun : MonoBehaviour
{
    [Header("Scripts")]
    [Tooltip("Reference to the main camera used for the player")]
    public aTarget target;

    [Header("Floats")]
    [Tooltip("Reference to the main camera used for the player")]
    public float damage = 10f;
    private float healthInt = 5;

    [Header("tmPro")]
    [Tooltip("Reference to the main camera used for the player")]
    public TextMeshProUGUI health;
    public TextMeshProUGUI enemybartext;
    [Header("Bools")]
    [Tooltip("Reference to the main camera used for the player")]
    public bool hitS;
    [Header("ParticleSystem")]
    [Tooltip("Reference to the main camera used for the player")]
    public ParticleSystem ps;

    [Header("Gameobjects")]
    [Tooltip("Reference to the main camera used for the player")]
    public GameObject objects;
    public GameObject gun;
    public GameObject posOne;
    public GameObject posTwo;

    //last number = what layer 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int layerMask = 1 << 3;

        if (Input.GetKey(KeyCode.R))
        {
            gun.transform.position = posTwo.transform.position;
        }

        else
        {
            gun.transform.position = posOne.transform.position;
        }
        
        if (Input.GetKeyDown(KeyCode.L) && hitS == true)
        {

            ShootEnemy();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {

            Shoot();
        }

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, layerMask))
        {
            if (hit.collider.gameObject.tag == "Enemy")
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                //Debug.Log("Did Hit");
                hitS = true;

                health.enabled = true;
                enemybartext.enabled = true;
            }

            else
            {
                hitS = false;
            }

            
 
        }

        else
        {
            hitS = false;
            health.enabled = false;
            enemybartext.enabled = false;
        }
    }

    void ShootEnemy()
    {
        print("poor billy he is dead");

        ps.Play();
        target.TakeDamage(damage);

            healthInt--;
            health.text = healthInt.ToString();

        
    }


    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            ps.Play();


            GameObject clone = Instantiate(objects, hit.point, Quaternion.identity);

            
            Destroy(clone, 1.0f);


        }

    }


}


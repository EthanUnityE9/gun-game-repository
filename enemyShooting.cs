using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class enemyShooting : MonoBehaviour
{
    public GameObject box;
    public ParticleSystem ps;
    public AudioSource ad;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Shoot", 10f);
    }

    // Update is called once per frame
    

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            if (hit.collider.gameObject.tag == "Player")
            {

                ps.Play();
                ad.Play();

                GameObject clone = Instantiate(box, hit.point, Quaternion.identity);

                Destroy(clone, 1.0f);

                Invoke("Shoot", 5f);
            }
        }
    }

   
}

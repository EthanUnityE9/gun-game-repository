using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerd : MonoBehaviour
{
    public GameObject objectt;
    public bool on;
    // Start is called before the first frame update
    void Start()
    {
        objectt.SetActive(false);
    }

    // Update is called once per frame

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "PlayerGuy")
        {
            //do blank

            objectt.SetActive(true);
            on = true;

        }

        
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.name == "PlayerGuy")
        {
            objectt.SetActive(false);
            on = false;
        }
    }
}

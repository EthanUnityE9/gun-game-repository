using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disapear : MonoBehaviour
{

    //im sorry billy

    public GameObject disapearthing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            disapearthing.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            disapearthing.SetActive(true);
        }

    }
}

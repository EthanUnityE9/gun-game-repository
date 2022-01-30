using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneFirst : MonoBehaviour
{
    public triggerd triggerd;
    public GameObject littleFace;
    
    public GameObject textOne;
    public GameObject textTwo;
    public GameObject textThree;
    public GameObject textFour;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(triggerd.on == true && Input.GetKeyDown(KeyCode.E))
        {
            trigercutscene();
        }

    }

    void trigercutscene()
    {
        littleFace.SetActive(true);
        
        textOne.SetActive(true);
        Invoke("PartTwo", 7f);

    }

    void PartTwo()
    {
        textOne.SetActive(false);
        textTwo.SetActive(true);
        Invoke("PartThree", 7f);
    }

    void PartThree()
    {
        textTwo.SetActive(false);
        textThree.SetActive(true);
        Invoke("PartFour", 7f);
    }

    void PartFour()
    {
        textThree.SetActive(false);
        textFour.SetActive(true);
        Invoke("stop", 7f);
    }

    void stop()
    {
        textFour.SetActive(false);
        
        littleFace.SetActive(false);
    }

}

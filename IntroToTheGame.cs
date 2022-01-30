using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroToTheGame : MonoBehaviour
{
    public GameObject eyeOne;
    public GameObject eyeTwo;
    public GameObject mouth;
    public GameObject backdrop;
    public Animation animationss;
    public bool on;
    public GameObject camStart;
    public GameObject camEnd;
    // Start is called before the first frame update
    void Start()
    {
        camStart.SetActive(true);
        camEnd.SetActive(false);
        
        on = true;
        animationss.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(on == true)
        {
            Invoke("firstPart", 9f);
            
        }
    }

    void firstPart()
    {
        
        eyeOne.SetActive(false);
        eyeTwo.SetActive(false);
        mouth.SetActive(false);
        backdrop.SetActive(false);
        on = false;

        camStart.SetActive(false);
        camEnd.SetActive(true);

    }
}

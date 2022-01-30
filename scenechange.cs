using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Netcode;
using HelloWorld;

public class scenechange : NetworkBehaviour
{
    public bool Client;
    public Camera cam1;
    public GameObject tmpro;
    public bool on;
    public GameObject player;
    
    
    // Start is called before the first frame update
    void Start()
    {
        on = true;
        Client = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M) && IsHost)
        {
            print("Working and is host");

            SceneManager.LoadScene(6);
            Client = false;
            Invoke("spawnPlayer", 5f);
            

        }

        

        if(SceneManager.sceneCount == 6 && on == true)
        {
            
            on = false;

        }
    }

    void spawnPlayer()
    {
        Instantiate(player, new Vector3(0, 0, 0), Quaternion.identity);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scenething : MonoBehaviour
{
    public GameObject buttons;

    public GameObject buttonsOnScreenTwo;


    public void PlayGame()
    {
        buttonsOnScreenTwo.SetActive(true);

        buttons.SetActive(false);

    }

    public void SettingsGame()
    {
        SceneManager.LoadScene(1);
    }

    public void MenuGame()
    {
        SceneManager.LoadScene(0);
    }

    public void TestGame()
    {
        SceneManager.LoadScene(2);
    }

    public void OnePlayer()
    {
        SceneManager.LoadScene(5);
    }

    public void MultiplayerGame()
    {
        SceneManager.LoadScene(4);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
   
    public void StartGame()
    {
        SceneManager.LoadScene(6);
    }
    public void controls()
    {
        SceneManager.LoadScene(4);
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene(5);
    }
    public void exitGame()
    {
        Application.Quit();
    }
}

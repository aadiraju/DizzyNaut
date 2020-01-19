using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public bool isPaused;
    void Start()
    {
        Time.timeScale = 0.0f;
    }

    void Update()
    {
        isPausedM();
    }
    void isPausedM()
    {
        if (!isPaused)
        {
            Time.timeScale = 1.0f;
        }
        else
        {
            Time.timeScale = 0.0f;
        }
    }
    public void Pause()
    {
        Debug.Log("Puase");
        if (isPaused)
        {
            isPaused = false;
        }
        else isPaused = true;
        
    }
    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}

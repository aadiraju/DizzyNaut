using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isPaused;
    void Start()
    {
        Time.timeScale = 0.0f;
    }

        void FixedUpdate()
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
    public static void Pause()
    {
        if (isPaused) isPaused = false;
        else isPaused = true;
        
    }
    public static void Exit()
    {
        Application.Quit();
    }
}

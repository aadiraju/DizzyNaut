using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isPaused;
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
}

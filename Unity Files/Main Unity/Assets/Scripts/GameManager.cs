using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject menuForm;
    public GameObject GameOverForm;
    public GameObject NextLevelForm;
    public GameObject StartForm;
    //public GameObject PanelGame;
    public void disactiveStartForm()
    {
        if (StartForm.activeSelf.Equals(true)) StartForm.SetActive(false);
        else StartForm.SetActive(true);
        Pause();
        //PanelGame.SetActive(true);
    }
    public void activeChangeNextLevelForm()
    {
        if (NextLevelForm.activeSelf.Equals(true)) NextLevelForm.SetActive(false);
        else NextLevelForm.SetActive(true);
        Pause();
    }
    public void activeChangeMenuForm()
    {
        if (menuForm.activeSelf.Equals(true)) menuForm.SetActive(false);
        else menuForm.SetActive(true);
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +  1);
        Debug.Log("next Scene");
    }
    public void activeChangeGameOverForm()
    {
        if (GameOverForm.activeSelf.Equals(true)) GameOverForm.SetActive(false);
        else GameOverForm.SetActive(true);
    }

    static public bool isPaused;
    void Start()
    {
        //Time.timeScale = 0.0f;
        StartForm.SetActive(true);
        //PanelGame.SetActive(false);
        Pause();
    }

    void Update()
    {
        isPausedM();
        Debug.Log(Time.deltaTime);
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
        Pause();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        Debug.Log("Exit");
        Application.Quit();
    }
}

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
    public GameObject canvas;
    public GameObject Char;
    //public GameObject PanelGame;
    public void UseSWFeature()
    {
        Char.GetComponent<StarWarsFeature>().useSWF();
    }
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

        //activeChangeMenuForm();
        //SceneManager.LoadScene(0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +  1);
        Debug.Log("next Scene");
        Pause();
        //Debug.Log("Active Scene name is: " + scene.name + "\nActive Scene index: " + scene.buildIndex);

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

        menuForm.SetActive(false);
        GameOverForm.SetActive(false);
        NextLevelForm.SetActive(false);
        //StartForm.SetActive(true);
        //Debug.Log(canvas.GetComponent<RectInt>().width + " " + canvas.GetComponent<RectInt>().height);

        //RectTransform objectRectTransform = canvas.GetComponent<RectTransform>();
        //float w = objectRectTransform.rect.width;
        //float h = objectRectTransform.rect.height;

        //Debug.Log("width: " + w + ", height: " + h);
        //menuForm.GetComponent<RectTransform>().localScale = new Vector2(6.37f * w, 1.45f * h);
        //menuForm.GetComponent<RectTransform>().sizeDelta = new Vector2((1274 / w) * 200, (506 / h) * 350);

    }

    void Update()
    {
        isPausedM();
        //Debug.Log(Time.deltaTime);
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
        //Pause();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        Debug.Log("Exit");
        Application.Quit();
    }
}

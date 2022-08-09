using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausa : MonoBehaviour
{
    public static bool GameIsPause = false;

    public GameObject PauseMenuUI;

    public GameObject win;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume ()
    {
        PauseMenuUI.SetActive(false);
       Time.timeScale = 1f;
        GameIsPause = false; 
    }
    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }
    public void CloseGame()
    {
    Debug.Log("Saliendo");
        Application.Quit();
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        GameIsPause = false;
        win.SetActive(true);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    private bool paused;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        paused = !paused;
        pausePanel.SetActive(paused);
        Time.timeScale = paused ? 0 : 1;  
    }

    public void ExitToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void Restart()
    {

        Time.timeScale = 1;
        SceneManager.LoadScene("MainGame");
    }
}
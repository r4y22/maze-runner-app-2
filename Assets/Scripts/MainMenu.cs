using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MainGame"); 
    }

    public void OpenLeaderboard()
    {
        SceneManager.LoadScene("Leaderboard");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
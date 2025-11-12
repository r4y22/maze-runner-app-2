using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MazeComplete : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeText;
    [SerializeField] TMP_InputField nameInput;

    void Start()
    {
  
        float t = PlayerPrefs.GetFloat("LastTime", -1f);
        if (t >= 0f)
        {
            int m = Mathf.FloorToInt(t / 60f);
            int s = Mathf.FloorToInt(t % 60f);
            timeText.text = $"Time: {m:00}:{s:00}";
        }
        else
        {
            timeText.text = "Time: --:--";
        }
    }

    public void SaveScore()
    {
        string name = nameInput.text.ToUpper();
        if (string.IsNullOrWhiteSpace(name))
        {
            name = "AAA";
        }

        float time = PlayerPrefs.GetFloat("LastTime", 0);
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        string timeString = $"{minutes:00}:{seconds:00}";
        string s0 = PlayerPrefs.GetString("Score0", "---");
        string s1 = PlayerPrefs.GetString("Score1", "---");


        PlayerPrefs.SetString("Score2", s1);
        PlayerPrefs.SetString("Score1", s0);
        PlayerPrefs.SetString("Score0", $"{name} - {timeString}");
        PlayerPrefs.Save();

        SceneManager.LoadScene("Leaderboard");
    }

    public void ReturnToMenu() => SceneManager.LoadScene("MainMenu");

    public void PlayAgain()
    {
        SceneManager.LoadScene("MainGame");
    }


    public void ExitGame()
    {

        Application.Quit();

    }
}

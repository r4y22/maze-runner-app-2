using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Leaderboard : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] scoreTexts;

    void Start()
    {
        LoadScores();
    }

    void LoadScores()
    {
        for (int i = 0; i < scoreTexts.Length; i++)
        {
            string key = "Score" + i;
            string score = PlayerPrefs.GetString(key, "---");
            scoreTexts[i].text = $"{i + 1}. {score}";
        }
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ClearLeaderboard()
    {
        PlayerPrefs.DeleteKey("Score0");
        PlayerPrefs.DeleteKey("Score1");
        PlayerPrefs.DeleteKey("Score2");
        PlayerPrefs.Save();
        LoadScores(); 
    }
}

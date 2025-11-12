using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerManager : MonoBehaviour
{
    public static TimerManager instance;
    [SerializeField] TextMeshProUGUI timerText;

    float elapsed;
    bool running = true;

    void Awake() 
    { 
        instance = this; 
    }

    void Update()
    {
        if (!running)
        {
            return;
        }
        elapsed += Time.deltaTime;
        int m = Mathf.FloorToInt(elapsed / 60f);
        int s = Mathf.FloorToInt(elapsed % 60f);
        if (timerText)
        {
            timerText.text = $"{m:00}:{s:00}";
        }
    }

    public void StopTimer() 
    { 
        running = false; 
    }
    public float GetElapsedTime() => elapsed;
}

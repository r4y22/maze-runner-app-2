using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }

        
        if (TimerManager.instance != null) {
             TimerManager.instance.StopTimer();
             PlayerPrefs.SetFloat("LastTime", TimerManager.instance.GetElapsedTime());
        }

        SceneManager.LoadScene("MazeComplete");
    }
}

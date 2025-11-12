using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private HashSet<string> collectedKeys = new HashSet<string>();

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddKey(string keyID) { 
        collectedKeys.Add(keyID); 
    }
    public bool HasKey(string keyID) => collectedKeys.Contains(keyID);
    public void UseKey(string keyID) { 
        collectedKeys.Remove(keyID); 
    }
}

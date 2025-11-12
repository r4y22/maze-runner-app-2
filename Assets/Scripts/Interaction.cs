using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public static Interaction instance;
    [SerializeField] private TextMeshProUGUI interactionText;

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

        if (interactionText != null)
        {
            interactionText.text = "";
        }
            
    }

    public void ShowMessage(string message)
    {
        if (interactionText != null)
        {
            interactionText.text = message;
        }
            
    }

    public void HideMessage()
    {
        if (interactionText != null)
        {
            interactionText.text = "";
        }
           
    }
}

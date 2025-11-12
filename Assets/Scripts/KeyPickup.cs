using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public string keyID = "A";
    public KeyCode interactKey = KeyCode.E;
    private bool isPlayerNearby = false;

    void Update()
    {
        if (isPlayerNearby && Input.GetKeyDown(interactKey))
        {
            GameManager.instance.AddKey(keyID);
            Interaction.instance.HideMessage();
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = true;
            Interaction.instance.ShowMessage($"Press E to pick up Key {keyID}");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = false;
            Interaction.instance.HideMessage();
        }
    }
}

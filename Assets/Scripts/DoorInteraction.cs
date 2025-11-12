using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public Transform door;               
    public float openAngle = 90f;        
    public float openSpeed = 2f;         
    public KeyCode interactKey = KeyCode.E;
    public string requiredKeyID = "A";   
    public bool requiresKey = true;      
 

    private bool isPlayerNearby = false;
    private bool isOpen = false;
    private Quaternion closedRotation;
    private Quaternion openRotation;
    private bool isUnlocked = false;

    void Start()
    {
        closedRotation = door.localRotation;
        openRotation = Quaternion.Euler(door.localEulerAngles.x, door.localEulerAngles.y + openAngle, door.localEulerAngles.z);
    }

    void Update()
    {
        if (isPlayerNearby && Input.GetKeyDown(interactKey))
        {
            if (requiresKey && !isUnlocked)
            {
                if (GameManager.instance.HasKey(requiredKeyID))
                {
                    GameManager.instance.UseKey(requiredKeyID);
                    isUnlocked = true;
                    isOpen = true;
                }

            }
            else
            {
           
                isOpen = !isOpen;
            }
        }

        if (isOpen)
        {
            door.localRotation = Quaternion.Slerp(door.localRotation, openRotation, Time.deltaTime * openSpeed);
        }
        else
        {
            door.localRotation = Quaternion.Slerp(door.localRotation, closedRotation, Time.deltaTime * openSpeed);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = true;
            Interaction.instance.ShowMessage($"Press E to open Door {requiredKeyID}");
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

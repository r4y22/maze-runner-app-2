using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target;         
    public float distance = 5.0f;   
    public float height = 2.0f;      
    public float smoothSpeed = 5.0f; 

    void LateUpdate()
    {
        if (!target)
        {
            return;
        }

        Vector3 desiredPosition = target.position - target.forward * distance + Vector3.up * height;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.LookAt(target.position + Vector3.up * 1.5f);
    }
}

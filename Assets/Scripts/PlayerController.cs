using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] float speed = 10f;
    [SerializeField] float gravity = -9.81f;
    [SerializeField] Animator anim;

    private Vector3 velocity;

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        // ----- CAMERA-RELATIVE DIRECTION -----
        Transform cam = Camera.main.transform;

        // flatten camera forward/right to avoid upward tilt
        Vector3 forward = cam.forward;
        Vector3 right = cam.right;
        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

        // combine inputs relative to camera
        Vector3 moveDir = forward * inputY + right * inputX;

        // ----- ROTATION -----
        if (moveDir.magnitude > 0.1f)
        {
            // Rotate player toward move direction
            Quaternion toRotation = Quaternion.LookRotation(moveDir, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, Time.deltaTime * 10f);
        }

        // ----- GRAVITY -----
        if (controller.isGrounded && velocity.y < 0)
            velocity.y = -1f;
        else
            velocity.y += gravity * Time.deltaTime;

        // ----- MOVE -----
        Vector3 move = moveDir * speed;
        move.y = velocity.y;
        controller.Move(move * Time.deltaTime);

        // ----- ANIMATION -----
        anim.SetBool("moving", moveDir.magnitude > 0.1f);
    }
}

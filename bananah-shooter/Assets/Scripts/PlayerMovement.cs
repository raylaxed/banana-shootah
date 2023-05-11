using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 2.5f;
    public float jumpForce = 2f;
    public float gravity = -9.81f;

    public float multiplier = -1f;
    public Transform groundCheck;
    public LayerMask groundMask;

    CharacterController controller;
    Vector3 velocity;
    bool isGrounded;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Check if the player is on the ground
        isGrounded = Physics.CheckSphere(groundCheck.position, 0.1f, groundMask);

        if (isGrounded && velocity.y < 0f)
        {
            velocity.y = multiplier;
        }

        // Get the horizontal and vertical inputs from the W, A, S, D keys
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Calculate the movement direction based on the inputs and the camera's forward direction
        Vector3 forwardDirection = Camera.main.transform.forward;
        Vector3 rightDirection = Camera.main.transform.right;
        forwardDirection.y = 0f;
        rightDirection.y = 0f;
        forwardDirection.Normalize();
        rightDirection.Normalize();
        Vector3 movementDirection = (forwardDirection * verticalInput + rightDirection * horizontalInput).normalized;

        // Apply gravity to the velocity
        velocity.y += gravity * Time.deltaTime;

        // Jump if the player presses the space bar and is on the ground
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpForce * multiplier * gravity);
        }

        // Move the player based on the movement direction and the velocity
        controller.Move(movementDirection * moveSpeed * Time.deltaTime + velocity * Time.deltaTime);
    }
}

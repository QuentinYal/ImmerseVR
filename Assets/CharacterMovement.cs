
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class VRPlayerMovement : MonoBehaviour
{
   
    public float moveSpeed = 2.0f;
    public float gravity = -9.81f;
    public float deadzone = 0.15f;

   
    public Transform head;

    private CharacterController controller;
    private float verticalVelocity;

    void Start()
    {
        controller = GetComponent<CharacterController>();

        if (head == null)
        {
            Debug.LogError("Assign CenterEyeAnchor to Head!");
        }
    }

    void Update()
    {
        if (head == null) return;

        // Read Quest 2 / Quest 3 left joystick
        Vector2 joystick = OVRInput.Get(
            OVRInput.Axis2D.PrimaryThumbstick,
            OVRInput.Controller.LTouch
        );

        // Prevent joystick drift
        if (joystick.magnitude < deadzone)
        {
            joystick = Vector2.zero;
        }

        joystick = Vector2.ClampMagnitude(joystick, 1f);

        // Get direction the player is looking
        Vector3 forward = head.forward;
        Vector3 right = head.right;

        // Keep movement horizontal
        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();

        // Calculate movement
        Vector3 moveDirection =
            forward * joystick.y +
            right * joystick.x;

        // Apply gravity
        if (controller.isGrounded && verticalVelocity < 0)
        {
            verticalVelocity = -2f;
        }

        verticalVelocity += gravity * Time.deltaTime;

        // Move player
        Vector3 velocity =
            moveDirection * moveSpeed +
            Vector3.up * verticalVelocity;

        controller.Move(velocity * Time.deltaTime);
    }
}

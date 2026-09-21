using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public float speed;
    private Rigidbody body;

    public Camera cam;

    public float mouseSensitivity;

    private float verticalRotation = 0f;

    private CharacterController controller;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        controller = GetComponent<CharacterController>();

    }

    private void Update()
    {
        HandleMovement();
        HandleMouseLook();
    }


    void HandleMovement()
    {
        // Get input
        float horizontal = Input.GetAxisRaw("Horizontal"); // A/D or Left/Right
        float vertical = Input.GetAxisRaw("Vertical");     // W/S or Up/Down

        // Calculate move direction relative to player rotation
        Vector3 move = transform.right * horizontal + transform.forward * vertical;

        // Determine current speed
        float currentSpeed = speed;

        // Move the controller
        controller.Move(move * currentSpeed * Time.deltaTime);

    }

    void HandleMouseLook()
    {
        if (Cursor.lockState != CursorLockMode.Locked) return;

        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // Rotate player horizontally
        transform.Rotate(Vector3.up * mouseX);

        // Rotate camera vertically
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -80, 80);

        if (cam != null)
        {
            cam.transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("type shi");
        if (collision.gameObject.layer == LayerMask.NameToLayer("monster"))
        {
            SceneManager.LoadScene("lose");
        }
    }
}
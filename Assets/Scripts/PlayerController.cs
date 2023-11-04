using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 4.0f;
    public float mouseSensitivity = 2.0f;

    public float worldOffset = 0.01f;

    public CharacterController cc;
    public Camera playerCamera;
    public Camera minerCamera;
    private float verticalRotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Player movement
        bool sprint = Input.GetButton("Sprint");
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 moveDirection = transform.TransformDirection(new Vector3(moveX, 0, moveZ).normalized);
        cc.SimpleMove(moveDirection * moveSpeed * (sprint ? 1.25f : 1f));

        // Player rotation
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90, 90);
        playerCamera.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);

        //Miner
        minerCamera.transform.localRotation = playerCamera.transform.rotation;
        minerCamera.transform.localPosition = transform.localPosition * worldOffset;

        transform.Rotate(Vector3.up * mouseX);

        // Unlock cursor when the player presses the escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Cursor.lockState == CursorLockMode.None)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }
}

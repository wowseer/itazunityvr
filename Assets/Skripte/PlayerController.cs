using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerController : MonoBehaviour
{
    public Transform headTransform; // Transform of the player's head
    public Transform rightHandTransform; // Transform of the player's right hand
    public Transform gunTransform; // Transform of the gun

    // Variables to store the movement input
    private Vector3 movementInput = Vector3.zero;

    // Function to update the player's movement
    private void Update()
    {
        // Get the movement input from Oculus Touch controller
        Vector3 touchpadMovement = OculusTouchInput.GetState(OVRTouchController.Right).touchpadAxis;

        // Normalize the touchpad movement
        touchpadMovement = Vector3.ClampMagnitude(touchpadMovement, 1f);

        // Apply the touchpad movement to the movement input
        movementInput = Vector3.Lerp(movementInput, touchpadMovement, Time.deltaTime * 2f);

        // Convert the movement input to world space
        Vector3 worldMovement = transform.TransformDirection(movementInput);

        // Apply the world movement to the player's transform
        transform.Translate(worldMovement * Time.deltaTime * 10f);

        // Set the gun's position to match the player's right hand
        gunTransform.position = rightHandTransform.position;
    }
}
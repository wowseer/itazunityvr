using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    public Rigidbody weaponRigidbody;
    public Transform weaponTransform;

    private bool isPickedUp = false;

    // OnCollisionEnter wird aufgerufen, wenn sich das Objekt mit einem anderen Objekt kollidiert.
    private void OnCollisionEnter(Collision collision)
    {
        // Wenn das andere Objekt ein Spieler ist, dann wird die Waffe aufgehoben.
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            isPickedUp = true;

            // Die Rotation der Waffe wird auf die Rotation des Spielers gesetzt.
            weaponTransform.rotation = collision.gameObject.transform.rotation;

            // Die Masse des Rigidbodies der Waffe wird auf 0 gesetzt, damit sie nicht mehr von der Physik beeinflusst wird.
            weaponRigidbody.mass = 0;

            // Die Waffe wird an die Hand des Spielers angehängt.
            transform.parent = collision.gameObject.transform;
        }
    }

    // OnTriggerExit wird aufgerufen, wenn sich das Objekt nicht mehr mit dem anderen Objekt kollidiert.
    private void OnTriggerExit(Collider other)
    {
        // Wenn die Waffe nicht mehr aufgehoben ist, dann wird sie fallengelassen.
        if (!isPickedUp)
        {
            // Die Masse des Rigidbodies der Waffe wird wieder auf die ursprüngliche Masse gesetzt.
            weaponRigidbody.mass = 1;

            // Die Waffe wird von der Hand des Spielers abgehängt.
            transform.parent = null;
        }
    }
}
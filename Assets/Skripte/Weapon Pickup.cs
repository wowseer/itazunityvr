using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WeaponPickup : MonoBehaviour
{
    // Referenz auf die Hand des Spielers
    private GameObject hand;

    // Referenz auf die Waffe
    private GameObject weapon;

    // Wird beim Starten des Scripts aufgerufen
    private void Start()
    {
        // Referenz auf die Hand des Spielers setzen
        hand = GameObject.FindWithTag("PlayerHand");

        // Referenz auf die Waffe setzen
        weapon = GetComponent<GameObject>();
    }

    // Wird aufgerufen, wenn die Waffe mit der Hand des Spielers interagiert wird
    private void OnTriggerEnter(Collider other)
    {
        // Wenn die andere Collider die Hand des Spielers ist
        if (other.gameObject == hand)
        {
            // Die Waffe aufheben
            Destroy(weapon);

            // Die Waffe in die Hand des Spielers legen
            hand.GetComponent<Transform>().position = weapon.transform.position;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float fireRate = 1f;
    public float projectileSpeed = 100f;
    public GameObject projectilePrefab;

    // Start is called before the first frame update.
    private void Start()
    {
        // Set the fire timer to the current time.
        fireTimer = Time.time;
    }

    // Update is called every frame.
    private void Update()
    {
        // If the fire button is pressed and the fire timer has expired, fire the weapon.
        if (Input.GetButtonDown("Fire") && Time.time >= fireTimer)
        {
            // Create a new projectile object.
            GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);

            // Set the projectile's velocity.
            projectile.GetComponent<Rigidbody2D>().velocity = transform.forward * projectileSpeed;

            // Reset the fire timer.
            fireTimer = Time.time + fireRate;
        }
    }

    private float fireTimer;
}
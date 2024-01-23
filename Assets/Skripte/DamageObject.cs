using UnityEngine;

public class DamageObject : MonoBehaviour
{
    public int damage;

    void OnTriggerEnter(Collider other)
    {
        PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
        }
    }
}
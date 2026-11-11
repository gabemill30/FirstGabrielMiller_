using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int healAmount = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerHealth.health = Mathf.Min(playerHealth.health + healAmount, 100);
            Destroy(gameObject); // remove this line if you want the pickup to stay
        }
    }
}
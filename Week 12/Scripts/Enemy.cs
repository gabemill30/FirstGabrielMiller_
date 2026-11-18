using UnityEngine;
using System.Collections;
using TMPro;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 40;

    public GameObject deathMessage;

    private bool isDead = false;

    public TMP_Text health;

    void Start()
    {
        health.text = "Health: " + enemyHealth;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.Contains("Bullet") && !isDead)
        {
            enemyHealth -= 10;
        }
    }

    void Update()
    {
        health.text = "Health: " + enemyHealth;
        if (enemyHealth <= 0 && !isDead)
        {
            StartCoroutine(Death());
        }
    }

    IEnumerator Death()
    {
        isDead = true;

        // Show death message
        deathMessage.SetActive(true);

        // Wait 1 second
        yield return new WaitForSeconds(1f);

        // Destroy enemy
        Destroy(gameObject);
        Destroy(deathMessage);
        Destroy(health);
    }
}

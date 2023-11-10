using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public Player_Control player;
    public int fullHealth = 100;
    public float invincibilityFrame;

    public HealthDisplay healthDisplay;

    private void Start()
    {
        player.currentHealth = fullHealth;
        healthDisplay.MaxHealth(fullHealth);
    }

    private void Update()
    {
        invincibilityFrame += Time.deltaTime;
        Debug.Log(invincibilityFrame);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy Bullets"))
        {
            if (invincibilityFrame > 1)
            {
                Debug.Log("Hit!");
                player.currentHealth -= BulletPhysics.bulletDamage;
                Debug.Log(player.health);
                healthDisplay.ChangeHealth(player.currentHealth);
                invincibilityFrame = 0;
            }
        }
    }
}

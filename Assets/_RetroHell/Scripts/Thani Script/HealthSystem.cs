using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int health = 100;
    public int fullHealth = 100;
    public float invincibilityFrame;

    public HealthDisplay healthDisplay;

    private void Start()
    {
        health = fullHealth;
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
                health -= BulletPhysics.bulletDamage;
                Debug.Log(health);
                healthDisplay.ChangeHealth(health);
                invincibilityFrame = 0;
            }
        }
    }
}

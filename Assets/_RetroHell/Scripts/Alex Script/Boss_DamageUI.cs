using UnityEngine;

public class Boss_DamageUI : MonoBehaviour
{
    public int maxHealth = 500;
    public int currentHealth;

    public Enemy_Health health;
    void Start()
    {
        currentHealth = maxHealth;
        health.SetMaxHealth(maxHealth);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullets")
        {
            TakeDamage(10);
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        health.SetHealth(currentHealth);
    }
}

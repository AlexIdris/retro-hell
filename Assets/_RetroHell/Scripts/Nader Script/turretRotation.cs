using UnityEngine;

public class turretRotation : MonoBehaviour
{
    public int maxHealth = 500;
    public int currentHealth;

    public Enemy_Health health;

    public float rotationDelay = 1f;
    private bool rotating = false;
    private void Start()
    {
        currentHealth = maxHealth;
        health.SetMaxHealth(maxHealth);
    }
    void Update()
    {
        if (Time.time >= rotationDelay && !rotating)
        {
            RotateTurret();
        }


    }
    public void RotateTurret()
    {
        transform.Rotate(0, 1, 0);
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
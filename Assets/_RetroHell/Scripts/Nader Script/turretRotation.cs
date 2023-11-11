using UnityEngine;

public class turretRotation : MonoBehaviour
{
    public float speed;
    public float rotationDelay = 1f;
    private bool rotating = false;

    [SerializeField] GameObject boss;
    [SerializeField] Boss_DamageUI bossHealth;

    void Update()
    {
        if (Time.time >= rotationDelay && !rotating)
        {
            RotateTurret();
        }

        if (bossHealth.currentHealth >= 375 && bossHealth.currentHealth <= 500)
        {
            speed = 0.5f;
        }

        if (bossHealth.currentHealth >= 250 && bossHealth.currentHealth <= 375)
        {
            speed = -1f;
        }

        if (bossHealth.currentHealth >= 125 && bossHealth.currentHealth <= 250)
        {
            speed = 2f;
        }

        if (bossHealth.currentHealth >= 0.1 && bossHealth.currentHealth <= 125)
        {
            speed = -3f;
        }

        if (bossHealth.currentHealth <= 0)
        {
            speed = 0;
        }
    }

    public void RotateTurret()
    {
        transform.Rotate(0, speed, 0);
    }



}
using UnityEngine;

public class MiniBossDamage : MonoBehaviour
{
    [SerializeField] GameObject iw_MiniBoss;
    [SerializeField] int maxHealth = 200;
    [SerializeField] GameObject healthGone;
    public int minicurrentHealth;
    public Miniturrent_Health health;
    // Start is called before the first frame update
    void Start()
    {
        minicurrentHealth = maxHealth;
        health.SetMaxHealth(maxHealth);

        iw_MiniBoss.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag is "Bullets")
        {
            TakeDamage(10);
            if (minicurrentHealth == 0)
            {

                healthGone.SetActive(false);
                iw_MiniBoss.SetActive(false);

                Destroy(healthGone);
                Destroy(gameObject);

            }
        }
    }
    public void TakeDamage(int damage)
    {
        minicurrentHealth -= damage;
        health.SetHealth(minicurrentHealth);
    }

}



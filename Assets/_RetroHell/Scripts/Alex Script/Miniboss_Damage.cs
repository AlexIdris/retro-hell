using UnityEngine;

public class Miniboss_Damage : MonoBehaviour
{
    [SerializeField] int maxHealth = 200;
    [SerializeField] GameObject healthGone;
    public int minicurrentHealth;
    public Miniturrent_Health health;
    // Start is called before the first frame update
    void Start()
    {
        minicurrentHealth = maxHealth;
        health.SetMaxHealth(maxHealth);
        healthGone.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullets")
        {
            TakeDamage(10);
            if (minicurrentHealth == 0)
            {
                Destroy(gameObject);
                healthGone.SetActive(false);
            }
        }
    }
    public void TakeDamage(int damage)
    {
        minicurrentHealth -= damage;
        health.SetHealth(minicurrentHealth);
    }

}



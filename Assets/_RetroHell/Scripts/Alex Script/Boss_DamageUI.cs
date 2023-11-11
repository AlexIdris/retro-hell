using UnityEngine;

public class Boss_DamageUI : MonoBehaviour
{
    [SerializeField] int maxHealth = 500;
    [SerializeField] int halfHealth = 250;
    public int currentHealth;


    [SerializeField] GameObject Bullet;
    [SerializeField] GameObject Bulletone;
    [SerializeField] GameObject Bullettwo;
    [SerializeField] GameObject Bulletthree;
    [SerializeField] GameObject Minions;
    [SerializeField] GameObject Minionsone;
    [SerializeField] GameObject Minionstwo;
    [SerializeField] GameObject Minionsthree;

    public Enemy_Health health;
    void Start()
    {
        currentHealth = maxHealth;
        health.SetMaxHealth(maxHealth);
        Minions.SetActive(false);
        Minionsone.SetActive(false);
        Minionstwo.SetActive(false);
        Minionsthree.SetActive(false);

        Bullet.SetActive(true);
        Bulletone.SetActive(true);
        Bullettwo.SetActive(true);
        Bulletthree.SetActive(true);
    }
    private void Update()
    {
        if (currentHealth <= halfHealth)
        {
            Minions.SetActive(true);
            Minionsone.SetActive(true);
            Minionstwo.SetActive(true);
            Minionsthree.SetActive(true);

            Bullet.SetActive(false);
            Bulletone.SetActive(false);
            Bullettwo.SetActive(false);
            Bulletthree.SetActive(false);
        }
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

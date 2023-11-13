using UnityEngine;

public class Boss_DamageUI : MonoBehaviour
{
    [SerializeField] int maxHealth = 1000;
    [SerializeField] int firstHealth = 750;
    [SerializeField] int halfHealth = 500;
    public int currentHealth;


    [SerializeField] GameObject secondhealthpattern;
    [SerializeField] GameObject firsthealthpattern;
    [SerializeField] GameObject thirdhealthpattern;
    bool first = false;
    bool second = false;



    public Enemy_Health health;
    void Start()
    {
        first = true;
        currentHealth = maxHealth;
        health.SetMaxHealth(maxHealth);

        firsthealthpattern.SetActive(true);
        secondhealthpattern.SetActive(false);
        thirdhealthpattern.SetActive(false);
    }

    private void Update()
    {

        if (currentHealth <= firstHealth && first)
        {
            Secondpattern();
            first = false;
            second = true;
        }
        if (currentHealth <= halfHealth && second)
        {
            Thirdpattern();

        }

    }
    void Secondpattern()
    {
        firsthealthpattern.SetActive(false);
        secondhealthpattern.SetActive(true);
        thirdhealthpattern.SetActive(false);


    }
    void Thirdpattern()
    {
        firsthealthpattern.SetActive(false);
        secondhealthpattern.SetActive(false);
        thirdhealthpattern.SetActive(true);
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

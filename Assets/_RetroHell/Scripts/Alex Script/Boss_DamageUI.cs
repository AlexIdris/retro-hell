using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss_DamageUI : MonoBehaviour
{
    [SerializeField] int maxHealth = 2000;
    [SerializeField] int firstHealth = 1500;
    [SerializeField] int halfHealth = 1000;
    [SerializeField] int lasthealth = 500;
    [SerializeField] int dead = 0;
    public int currentHealth;


    [SerializeField] GameObject secondhealthpattern;
    [SerializeField] GameObject firsthealthpattern;
    [SerializeField] GameObject thirdhealthpattern;
    [SerializeField] GameObject fourthhealthpattern;
    [SerializeField] GameObject miniturrenthealth;
    [SerializeField] BossShield ShieldCode;
    [SerializeField] GameObject ShieldObject;

    bool first = false;
    bool second = false;
    bool third = false;
    bool fourth = false;

    public Enemy_Health health;
    void Start()
    {
        first = true;
        currentHealth = maxHealth;
        health.SetMaxHealth(maxHealth);

        firsthealthpattern.SetActive(true);
        secondhealthpattern.SetActive(false);
        thirdhealthpattern.SetActive(false);
        fourthhealthpattern.SetActive(false);
        miniturrenthealth.SetActive(false);

        ShieldCode = ShieldObject.GetComponent<BossShield>();
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
            first = false;
            second = false;
            third = true;
        }
        if (currentHealth <= lasthealth && third)
        {
            Fourthpattern();
            first = false;
            second = false;
            third = false;
            fourth = true;

            ShieldCode.Activate();
        }
        if (currentHealth == dead && fourth)
        {

            SceneManager.LoadScene(0);
        }

    }
    void Secondpattern()
    {
        firsthealthpattern.SetActive(false);
        secondhealthpattern.SetActive(true);
        thirdhealthpattern.SetActive(false);
        fourthhealthpattern.SetActive(false);
        miniturrenthealth.SetActive(false);
    }
    void Thirdpattern()
    {
        firsthealthpattern.SetActive(false);
        secondhealthpattern.SetActive(false);
        thirdhealthpattern.SetActive(true);
        fourthhealthpattern.SetActive(false);
        miniturrenthealth.SetActive(false);
    }
    void Fourthpattern()
    {
        firsthealthpattern.SetActive(true);
        secondhealthpattern.SetActive(false);
        thirdhealthpattern.SetActive(false);
        fourthhealthpattern.SetActive(true);
        miniturrenthealth.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullets" && ShieldCode.activated == false)
        {
            TakeDamage(10); if (currentHealth == 0)
            {
                OnDeath();
            }
        }

    }
    void OnDeath()
    {
        SceneManager.LoadScene(1);
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        health.SetHealth(currentHealth);
    }

}

using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss_DamageUI : MonoBehaviour
{
    public int maxHealth = 5000;
    public int firstHealth = 4000;
    public int halfHealth = 3000;
    public int lasthealth = 2010;
    public int lasthealthsecorndpattern = 2000;
    private int dead = 0;
    public int currentHealth;

    [SerializeField] float timer = 0;
    [SerializeField] float delay = 2;


    [SerializeField] GameObject secondhealthpattern;
    [SerializeField] GameObject firsthealthpattern;
    [SerializeField] GameObject thirdhealthpattern;
    [SerializeField] GameObject fourthhealthpattern;
    [SerializeField] GameObject miniturrenthealth;
    [SerializeField] BossShield ShieldCode;
    [SerializeField] GameObject ShieldObject;
    [SerializeField] GameObject FirstForm;
    [SerializeField] GameObject LastForm;
    [SerializeField] Animator animator;


    bool first = false;
    bool second = false;
    bool third = false;
    bool fourth = false;
    bool fiveth = false;
    public Enemy_Health health;
    void Start()
    {

        currentHealth = maxHealth;
        //health.SetMaxHealth(maxHealth);
        first = true;

        firsthealthpattern.SetActive(true);
        secondhealthpattern.SetActive(false);
        thirdhealthpattern.SetActive(false);
        fourthhealthpattern.SetActive(false);
        miniturrenthealth.SetActive(false);

        ShieldCode = ShieldObject.GetComponent<BossShield>();
        FirstForm.SetActive(true);
        LastForm.SetActive(false);
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
        if (currentHealth <= lasthealthsecorndpattern && fourth)
        {
            Fivethpattern();
        }
        if (currentHealth == dead && fourth)
        {

            SceneManager.LoadScene(5);
        }
        if (currentHealth <= firstHealth && currentHealth > lasthealth)
        {
            animator.enabled = true;
            timer += Time.deltaTime;
            if (timer >= delay)
            {
                animator.enabled = false;
            }
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
        animator.enabled = false;
        thirdhealthpattern.SetActive(true);
        fourthhealthpattern.SetActive(false);
        miniturrenthealth.SetActive(false);
    }
    void Fourthpattern()
    {
        FirstForm.SetActive(false);
        LastForm.SetActive(true);
        firsthealthpattern.SetActive(true);
        secondhealthpattern.SetActive(false);
        animator.enabled = false;
        thirdhealthpattern.SetActive(false);
        fourthhealthpattern.SetActive(true);
        miniturrenthealth.SetActive(true);
    }
    void Fivethpattern()
    {
        firsthealthpattern.SetActive(true);
        secondhealthpattern.SetActive(true);
        animator.enabled = true;
        thirdhealthpattern.SetActive(true);
        fourthhealthpattern.SetActive(false);
        miniturrenthealth.SetActive(false);
        animator.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullets" && ShieldCode.activated == false)
        {
            EnemyTakeDamage(10);

            if (currentHealth == 0)
            {
                OnDeath();
            }
        }

    }
    void OnDeath()
    {
        SceneManager.LoadScene(2);
    }
    public void EnemyTakeDamage(int damage)
    {
        currentHealth -= damage;
        health.SetHealth(currentHealth);
    }

}

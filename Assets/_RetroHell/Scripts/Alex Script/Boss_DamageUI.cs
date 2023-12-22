using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss_DamageUI : MonoBehaviour
{
    public int maxHealth = 4000;
    public int firstHealth = 3000;
    public int halfHealth = 2500;
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
    [SerializeField] BossShield shieldCode;
    [SerializeField] GameObject shieldObject;
    [SerializeField] GameObject firstForm;
    [SerializeField] GameObject lastForm;



    bool first = false;
    bool second = false;
    bool third = false;
    bool fourth = false;

    public EnemyHealth health;
    void Start()
    {

        currentHealth = maxHealth;
        health.SetHealth(maxHealth);
        first = true;

        firsthealthpattern.SetActive(true);
        secondhealthpattern.SetActive(false);
        thirdhealthpattern.SetActive(false);
        fourthhealthpattern.SetActive(false);
        miniturrenthealth.SetActive(false);

        shieldCode = shieldObject.GetComponent<BossShield>();
        firstForm.SetActive(true);
        lastForm.SetActive(false);
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

            shieldCode.Activate();
        }
        if (currentHealth <= lasthealthsecorndpattern && fourth)
        {
            Fivethpattern();
        }
        if (currentHealth == dead && fourth)
        {

            SceneManager.LoadScene(5);
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
    void Fivethpattern()
    {
        firstForm.SetActive(false);
        lastForm.SetActive(true);
        firsthealthpattern.SetActive(true);
        secondhealthpattern.SetActive(true);

        thirdhealthpattern.SetActive(true);
        fourthhealthpattern.SetActive(false);
        miniturrenthealth.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag is "Bullets" && shieldCode.activated == false)
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

        SceneManager.LoadScene(3);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }
    public void EnemyTakeDamage(int damage)
    {
        currentHealth -= damage;
        health.SetHealth(currentHealth);
    }

}

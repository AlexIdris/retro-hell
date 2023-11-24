using UnityEngine;

public class BossShield : MonoBehaviour
{
    public GameObject miniBoss1;
    public GameObject miniBoss2;
    public GameObject miniBoss3;
    public GameObject miniBoss4;
    public Miniboss_Damage miniBoss1Health;
    public Miniboss_Damage miniBoss2Health;
    public Miniboss_Damage miniBoss3Health;
    public Miniboss_Damage miniBoss4Health;

    public GameObject mainBoss;
    public Boss_DamageUI mainBossHealth;
    public GameObject bossShield;
    public bool activated;

    void Start()
    {
        miniBoss1Health = miniBoss1.GetComponent<Miniboss_Damage>();
        miniBoss2Health = miniBoss2.GetComponent<Miniboss_Damage>();
        miniBoss3Health = miniBoss3.GetComponent<Miniboss_Damage>();
        miniBoss4Health = miniBoss4.GetComponent<Miniboss_Damage>();
        mainBossHealth = mainBoss.GetComponent<Boss_DamageUI>();
    }

    public void Update()
    {
        if (miniBoss1Health.minicurrentHealth == 0 && miniBoss2Health.minicurrentHealth == 0 && miniBoss3Health.minicurrentHealth == 0 && miniBoss4Health.minicurrentHealth == 0)
        {
            activated = false;
            bossShield.SetActive(false);
        }
    }

    public void Activate()
    {
        bossShield.SetActive(true);
        activated = true;
        Debug.Log("Shield Activated!");

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullets")
        {
            Destroy(other.gameObject);
        }
    }
}

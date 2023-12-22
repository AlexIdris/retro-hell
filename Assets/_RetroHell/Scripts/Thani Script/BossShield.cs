using UnityEngine;

public class BossShield : MonoBehaviour
{
    public GameObject miniBoss1;
    public GameObject miniBoss2;
    public GameObject miniBoss3;
    public GameObject miniBoss4;
    public MiniBossDamage miniBoss1Health;
    public MiniBossDamage miniBoss2Health;
    public MiniBossDamage miniBoss3Health;
    public MiniBossDamage miniBoss4Health;

    public GameObject mainBoss;
    public Boss_DamageUI mainBossHealth;
    public GameObject bossShield;
    public bool activated;

    void Start()
    {
        miniBoss1Health = miniBoss1.GetComponent<MiniBossDamage>();
        miniBoss2Health = miniBoss2.GetComponent<MiniBossDamage>();
        miniBoss3Health = miniBoss3.GetComponent<MiniBossDamage>();
        miniBoss4Health = miniBoss4.GetComponent<MiniBossDamage>();
        mainBossHealth = mainBoss.GetComponent<Boss_DamageUI>();
    }

    public void FixedUpdate()
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject boss;
    public Boss_DamageUI bossHealth;
    public GameObject whatObject;
    public GameObject objectSpawner;
    public bool criticalHealth;

    void Start()
    {
        bossHealth = boss.GetComponent<Boss_DamageUI>();
        criticalHealth = false;
    }

    void Update()
    {
        if (bossHealth.currentHealth <= 250 && criticalHealth == false)
        {
            Instantiate(whatObject, objectSpawner.transform.position, objectSpawner.transform.rotation);
            criticalHealth = true;
        }
    }
}

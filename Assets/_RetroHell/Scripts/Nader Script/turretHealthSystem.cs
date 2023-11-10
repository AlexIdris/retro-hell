using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretHealthSystem : MonoBehaviour
{
    [SerializeField] GameObject boss;
    [SerializeField] Boss_DamageUI bossHealth;
    // Start is called before the first frame update
    void Start()
    {
        boss = GameObject.FindGameObjectWithTag("Boss");
        bossHealth = boss.GetComponent<Boss_DamageUI>();
    }

    // Update is called once per frame
    void Update()
    {
       /* if (bossHealth.currentHealth > 250 &&)
        {

        }*/
    }
}

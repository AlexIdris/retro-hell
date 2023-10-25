using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int health;
    public float invincibilityFrame;

    private void Update()
    {
        invincibilityFrame += Time.deltaTime;
        Debug.Log(invincibilityFrame);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (invincibilityFrame > 1)
            {
                Debug.Log("Hit!");
                health -= 1;
                Debug.Log(health);
                invincibilityFrame = 0;
            }
        }
    }
}

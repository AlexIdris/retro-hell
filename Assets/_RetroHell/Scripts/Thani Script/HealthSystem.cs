using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public float invincibilityFrame;

    private void Update()
    {
        invincibilityFrame += Time.deltaTime;
        Debug.Log(invincibilityFrame);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Bullets"))
        {
            if (invincibilityFrame > 1)
            {
                Debug.Log("Hit!");
                HealthDisplay.health -= BulletPhysics.bulletDamage;
                Debug.Log(HealthDisplay.health);
                invincibilityFrame = 0;
            }
        }
    }
}

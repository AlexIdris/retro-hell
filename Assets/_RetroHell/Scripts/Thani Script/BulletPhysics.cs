using UnityEngine;

public class BulletPhysics : MonoBehaviour
{
    public float timeAwake;
    public static int bulletDamage;

    private void Start()
    {
        bulletDamage = 5;
    }

    private void FixedUpdate()
    {
        timeAwake += Time.deltaTime;

        if (timeAwake >= 2)
        {
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Breakable Wall")
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            Boss_DamageUI playerHealth = other.gameObject.GetComponent<Boss_DamageUI>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(10);
            }
        }
        if (other.gameObject.tag == "Bullets")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Shield")
        {
            Destroy(gameObject);
        }
        Destroy(gameObject);

    }


}

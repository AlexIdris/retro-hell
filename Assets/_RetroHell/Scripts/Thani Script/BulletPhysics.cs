using UnityEngine;

public class BulletPhysics : MonoBehaviour
{
    [SerializeField] float playerBulletTimeAwake;
    [SerializeField] float awaken;
    public static int bulletDamage;

    private void Start()
    {
        bulletDamage = 10;
    }

    private void FixedUpdate()
    {
        playerBulletTimeAwake += Time.deltaTime;

        if (playerBulletTimeAwake >= awaken)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Breakable Wall")
        {
            Destroy(other.gameObject);
        }

        if (other.tag == "Boss")
        {
            Boss_DamageUI playerHealth = other.gameObject.GetComponent<Boss_DamageUI>();
            if (playerHealth != null)
            {
                Destroy(gameObject);
            }
        }

        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        if (other.tag == "EnemyBullets")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        if (other.tag == "Shield")
        {
            Destroy(gameObject);
        }
    }
}

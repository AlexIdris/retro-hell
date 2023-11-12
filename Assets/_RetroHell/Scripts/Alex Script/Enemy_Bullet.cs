using UnityEngine;

public class Enemy_Bullet : MonoBehaviour
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

        if (timeAwake >= 5)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Breakable Wall")
        {

        }

        if (other.gameObject.CompareTag("Player"))
        {
            Boss_DamageUI playerHealth = other.gameObject.GetComponent<Boss_DamageUI>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(10);

            }
        }

        if (other.gameObject.tag == "Bullets")
        {
            Destroy(gameObject);
        }

        Destroy(gameObject);

    }
}

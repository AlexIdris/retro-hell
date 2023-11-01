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

        if (timeAwake >= 3)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Breakable Wall")
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Player"))
        {
            Boss_DamageUI playerHealth = other.gameObject.GetComponent<Boss_DamageUI>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(10);
            }
        }
        Destroy(gameObject);

    }
}

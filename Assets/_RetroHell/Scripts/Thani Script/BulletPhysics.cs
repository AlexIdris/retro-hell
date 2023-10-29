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

        if (timeAwake >= 3)
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
            turretRotation playerHealth = other.gameObject.GetComponent<turretRotation>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(10);
            }
        }
        Destroy(gameObject);

    }


}

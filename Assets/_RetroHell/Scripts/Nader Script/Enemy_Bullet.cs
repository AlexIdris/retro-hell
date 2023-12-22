using UnityEngine;

public class Enemy_Bullet : MonoBehaviour
{
    [SerializeField] float timeAwake;
    public static int bulletDamage;

    private void Start()
    {
        bulletDamage = 5;
    }

    private void FixedUpdate()
    {
        timeAwake += Time.deltaTime;

        if (timeAwake >= 10)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Breakable Wall")
        {
            Destroy(gameObject);
        }

        if (other.tag == "Player")
        {
            Player_Control playerHealth = other.gameObject.GetComponent<Player_Control>();

            if (playerHealth != null)
            {

                Destroy(gameObject);

            }
        }
        if (other.tag == "Wall")
        {
            Destroy(gameObject);
        }
        if (other.tag == "EnemyBullets")
        {
            Destroy(gameObject);
        }





    }
}

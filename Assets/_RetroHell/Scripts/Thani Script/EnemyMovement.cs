using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 0.1f;
    public float currentDistance;
    public bool shooting;
    [SerializeField] GameObject target;
    [SerializeField] float playerDistance = 5f;

    public GameObject bullet;
    [SerializeField] GameObject bulletSpawner;
    public float bulletSpeed;
    public float invincibilityFrame;

    [SerializeField] float nextFireTime = 0f;
    [SerializeField] float fireRate = 1.0f;
    public void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        bullet = GameObject.FindGameObjectWithTag("Enemy Bullet");
        bulletSpawner = GameObject.FindGameObjectWithTag("Enemy Bullet Spawner");
    }

    public void Update()
    {
        var movement = speed * Time.fixedDeltaTime;
        currentDistance = Vector3.Distance(transform.position, target.transform.position);
        Debug.Log(currentDistance);

        shooting = true;
        invincibilityFrame += Time.deltaTime;

        transform.rotation = Quaternion.LookRotation(target.transform.position - transform.position, transform.up);

        if (currentDistance > playerDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, movement);
            shooting = false;
        }

        if (shooting == true && invincibilityFrame > 0.2 && Time.time > nextFireTime)
        {
            Shoot();
            Debug.Log("Shot a bullet!");
            invincibilityFrame = 0;
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    public void Shoot()
    {
        var bulletSample = Instantiate(bullet, bulletSpawner.transform.position, bulletSpawner.transform.rotation);
        bulletSample.GetComponent<Rigidbody>().velocity = bulletSpawner.transform.forward * bulletSpeed;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullets")
        {
            Destroy(gameObject);
        }
        if (other.tag == "Enemy Bullets")
        {
            Destroy(other.gameObject);
        }
    }
}

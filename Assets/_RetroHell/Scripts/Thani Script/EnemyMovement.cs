using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 0.1f;
    public float currentDistance;
    public bool shooting;
    [SerializeField] GameObject target;
    [SerializeField] float playerDistance = 5f;
    [SerializeField] GameObject bulletSpawner;
    public GameObject bullet;
    public PauseSystem pause;
    public float bulletSpeed = 1f;
    public float invincibilityFrame;

    [SerializeField] float nextFireTime = 0f;
    [SerializeField] float fireRate = 1.0f;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    public void FixedUpdate()
    {
        var movement = speed * Time.fixedDeltaTime;
        currentDistance = Vector3.Distance(transform.position, target.transform.position);
        Debug.Log(currentDistance);

        shooting = true;
        invincibilityFrame += Time.deltaTime;

        if (currentDistance > playerDistance && pause.gamePaused == false)
        {
            transform.rotation = Quaternion.LookRotation(target.transform.position - transform.position, transform.up);

            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, movement);
            shooting = false;
        }

        if (shooting == true && invincibilityFrame > 0.2 && Time.time > nextFireTime && pause.gamePaused == false)
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
        if (other.tag == "EnemyBullets")
        {
            Destroy(other.gameObject);
        }
    }
}

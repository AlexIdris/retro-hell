using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private GameObject smoke;
    public bool shooting;

    [SerializeField] GameObject bulletSpawner;
    public GameObject bullet;
    public PauseSystem pause;
    public float bulletSpeed = 1f;
    public float invincibilityFrame;
    [SerializeField] Minion_shooting minion_Shooting;
    [SerializeField] float nextFireTime = 0f;
    [SerializeField] float fireRate = 1.0f;

    void Start()
    {
        minion_Shooting.target = GameObject.FindGameObjectWithTag("Player");
        smoke.SetActive(false);
    }

    public void FixedUpdate()
    {


        shooting = true;
        invincibilityFrame += Time.deltaTime;



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
    private void OnDestroy()
    {
        smoke.SetActive(true);
    }
}

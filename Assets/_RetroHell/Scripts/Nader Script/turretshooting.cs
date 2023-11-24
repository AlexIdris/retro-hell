using UnityEngine;

public class turretshooting : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform bulletBarrel;
    [SerializeField] float fireRate = 1.0f;
    [SerializeField] float bulletSpeed = 10f;
    [SerializeField] float nextFireTime = 0f;
    public PauseSystem pause;

    public void Update()
    {
        if (Time.time > nextFireTime && pause.gamePaused == false)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    void Shoot()
    {
        GameObject bulletInstance = Instantiate(bulletPrefab, bulletBarrel.position, bulletBarrel.rotation);
        Rigidbody rb = bulletInstance.GetComponent<Rigidbody>();
        rb.velocity = bulletBarrel.forward * bulletSpeed;
    }
}

using System.Collections;
using UnityEngine;

public class turretshooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;    
    public float fireRate = 1.0f;  
    public float bulletSpeed = 10f;
    public float nextFireTime = 0f;

    private void Update()
    {
        if (Time.time > nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    void Shoot()
    {
        GameObject bulletInstance = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bulletInstance.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.velocity = firePoint.forward * bulletSpeed;
        }
    }
}

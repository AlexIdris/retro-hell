using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 0.1f;
    public float currentDistance;
    public bool shooting;
    public Transform target;

    public GameObject bullet;
    [SerializeField] Transform bulletSpawner;
    public float bulletSpeed;
    public float invincibilityFrame;

    public void Update()
    {
        var movement = speed * Time.fixedDeltaTime;
        currentDistance = Vector3.Distance(transform.position, target.transform.position);
        Debug.Log(currentDistance);

        shooting = true;
        invincibilityFrame += Time.deltaTime;

        transform.rotation = Quaternion.LookRotation(target.position - transform.position, transform.up);

        if (currentDistance > 10)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, movement);
            shooting = false;
        }

        if (shooting == true && invincibilityFrame > 0.2)
        {
            Shoot();
            Debug.Log("Shot a bullet!");
            invincibilityFrame = 0;
        }
    }

    public void Shoot()
    {
        var bulletSample = Instantiate(bullet, bulletSpawner.position, bulletSpawner.rotation);
        bulletSample.GetComponent<Rigidbody>().velocity = bulletSpawner.forward * bulletSpeed;
    }
}

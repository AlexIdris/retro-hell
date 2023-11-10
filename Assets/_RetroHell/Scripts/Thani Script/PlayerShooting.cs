using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    [SerializeField] Transform bulletSpawner;
    public float bulletSpeed;
    public float invincibilityFrame;

    private void Update()
    {
        invincibilityFrame += Time.deltaTime;

        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (invincibilityFrame > 0.1)
            {
                Shoot();
                Debug.Log("Shot a bullet!");
                invincibilityFrame = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (invincibilityFrame > 0.1)
            {
                Shoot();
                Debug.Log("Shot a bullet!");
                invincibilityFrame = 0;
            }
        }
    }

    public void Shoot()
    {
        var bulletSample = Instantiate(bullet, bulletSpawner.position, bulletSpawner.rotation);
        bulletSample.GetComponent<Rigidbody>().velocity = bulletSpawner.forward * bulletSpeed;
    }
}

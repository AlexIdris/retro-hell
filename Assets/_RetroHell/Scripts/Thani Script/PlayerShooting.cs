using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    [SerializeField] Transform bulletSpawner;
    public float bulletSpeed;
    public float invincibilityFrame;
    public int machineGunBullets;
    public bool machineGunObtained;

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
        if (Input.GetKeyDown("o"))
        {
            if (invincibilityFrame > 0.1)
            {
                Shoot();
                Debug.Log("Shot a bullet!");
                invincibilityFrame = 0;
            }
        }

        if (Input.GetKey("p") && machineGunObtained == true && machineGunBullets > 0)
        {
            if (invincibilityFrame > 0.1)
            {
                Shoot();
                Debug.Log("Shot a bullet!");
                invincibilityFrame = 0;
                machineGunBullets -= 1;
            }
        }

        if (machineGunBullets == 0)
        {
            machineGunObtained = false;
        }
    }

    public void Shoot()
    {
        var bulletSample = Instantiate(bullet, bulletSpawner.position, bulletSpawner.rotation);
        bulletSample.GetComponent<Rigidbody>().velocity = bulletSpawner.forward * bulletSpeed;
    }
}

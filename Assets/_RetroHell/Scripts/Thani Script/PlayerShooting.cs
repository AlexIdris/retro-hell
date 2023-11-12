using UnityEngine;

public class PlayerShooting : MonoBehaviour
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

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (invincibilityFrame > 0.1)
            {
                Shoot();
                Debug.Log("Shot a bullet!");
                invincibilityFrame = 0;
            }
        }



        if (Input.GetKey(KeyCode.Mouse1) && machineGunObtained == true && machineGunBullets > 0)
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

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "MachineGun")
        {
            machineGunObtained = true;
            machineGunBullets = 50;
        }
    }
}

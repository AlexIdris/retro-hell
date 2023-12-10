using TMPro;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip playerShooting;
    public GameObject bullet;
    [SerializeField] Transform bulletSpawner;
    [SerializeField] GameObject machineGun;
    public float bulletSpeed;
    public float invincibilityFrame;
    public int machineGunBullets;
    public bool machineGunObtained;

    [SerializeField] TMP_Text bullettext;

    private void FixedUpdate()
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
                bullettext.text = machineGunBullets.ToString();
            }
        }

        if (machineGunBullets == 0)
        {
            machineGunObtained = false;
            bullettext.text = machineGunBullets.ToString();
            machineGun.SetActive(false);
        }
    }

    public void Shoot()
    {
        var bulletSample = Instantiate(bullet, bulletSpawner.position, bulletSpawner.rotation);
        bulletSample.GetComponent<Rigidbody>().velocity = bulletSpawner.forward * bulletSpeed;
        Audio.clip = playerShooting;
        Audio.Play();
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

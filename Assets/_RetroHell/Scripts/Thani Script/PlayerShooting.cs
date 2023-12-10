using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] GameObject Audio;

    public GameObject bullet;
    [SerializeField] Transform bulletSpawner;
    [SerializeField] GameObject machineGun;
    public float bulletSpeed;
    public float invincibilityFrame;
    public int machineGunBullets;
    public bool machineGunObtained;

    [SerializeField] TMP_Text bullettext;
    private void Awake()
    {
        Audio.SetActive(false);
    }
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

    public async void Shoot()
    {
        var bulletSample = Instantiate(bullet, bulletSpawner.position, bulletSpawner.rotation);
        bulletSample.GetComponent<Rigidbody>().velocity = bulletSpawner.forward * bulletSpeed;
        Audio.SetActive(true);
        await Task.Delay(50);
        Audio.SetActive(false);
        await Task.Delay(50);
        Audio.SetActive(true);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "MachineGun")
        {
            machineGunObtained = true;
            machineGunBullets = 50;
        }
    }
}

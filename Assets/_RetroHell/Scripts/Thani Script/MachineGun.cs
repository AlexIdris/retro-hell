using TMPro;
using UnityEngine;

public class MachineGun : MonoBehaviour
{
    public Player_Control player;
    public PlayerShooting playerControls;

    [SerializeField] TMP_Text bullettext;
    [SerializeField] GameObject machineGun;

    private void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            playerControls.machineGunObtained = true;
            playerControls.machineGunBullets = 50;
            machineGun.SetActive(true);
            bullettext.text = playerControls.machineGunBullets.ToString();
            Destroy(gameObject);
        }
    }
}

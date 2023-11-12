using TMPro;
using UnityEngine;

public class MachineGun : MonoBehaviour
{
    public Player_Control player;
    public Shooting playerControls;

    [SerializeField] TMP_Text bullettext;
    [SerializeField] GameObject machineGun;

    private void Start()
    {

    }
    public void OnCollisionEnter(Collision other)
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

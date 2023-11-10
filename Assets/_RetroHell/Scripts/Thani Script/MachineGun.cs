using UnityEngine;

public class MachineGun : MonoBehaviour
{
    public Player_Control player;
    public Shooting playerControls;

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerControls.machineGunObtained = true;
            playerControls.machineGunBullets = 50;
            Destroy(gameObject);
        }
    }
}

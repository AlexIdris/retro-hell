using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : MonoBehaviour
{
    public GameObject player;
    public PlayerShooting playerControls;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerControls = player.GetComponent<PlayerShooting>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerControls.machineGunObtained = true;
            playerControls.machineGunBullets = 50;
            Destroy(gameObject);
        }
    }
}

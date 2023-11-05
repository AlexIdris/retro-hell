using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpHealth : MonoBehaviour
{
    public Player_Control player;
    public int extraHealth;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.currentHealth += extraHealth;
            Destroy(gameObject);
        }
    }
}

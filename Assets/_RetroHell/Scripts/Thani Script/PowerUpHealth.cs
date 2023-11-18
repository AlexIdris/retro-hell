using UnityEngine;

public class PowerUpHealth : MonoBehaviour
{
    public GameObject player;
    public Player_Control playerHealth;
    public int extraHealth;


    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<Player_Control>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerHealth.playercurrentHealth += extraHealth;
            playerHealth.health.ChangeHealth(playerHealth.playercurrentHealth);
            Destroy(gameObject);
        }
    }

}

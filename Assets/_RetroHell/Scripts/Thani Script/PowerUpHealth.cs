using UnityEngine;

public class PowerUpHealth : MonoBehaviour
{
    public GameObject player;
    public Player_Control playerHealth;
    public int extraHealth;
    public GameObject animatorObject;
    public PowerUpIconAnimator animator;
    public HealthDisplay healthDisplay;
    private bool FullHealth;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<Player_Control>();


        healthDisplay = player.GetComponent<HealthDisplay>();
        bool FullHealth = healthDisplay.fullHealth;

    }


    public void Awake()
    {
        animatorObject = GameObject.FindGameObjectWithTag("Animator");
        animator = animator.GetComponent<PowerUpIconAnimator>();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            playerHealth.playercurrentHealth += extraHealth;
            playerHealth.health.ChangeHealth(playerHealth.playercurrentHealth);
            animator.HealthAnimation();
            Destroy(gameObject);
        }
    }
}

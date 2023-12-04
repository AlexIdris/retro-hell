using UnityEngine;

public class PowerUpHealth : MonoBehaviour
{
    public GameObject player;
    public Player_Control playerHealth;
    public int extraHealth;
    public GameObject animatorObject;
    public PowerUpIconAnimator animator;

    public float timer;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<Player_Control>();

        animatorObject = GameObject.FindGameObjectWithTag("Animator");
        animator = animatorObject.GetComponent<PowerUpIconAnimator>();
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

    public void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer > 10)
        {
            Destroy(gameObject);
        }
    }
}

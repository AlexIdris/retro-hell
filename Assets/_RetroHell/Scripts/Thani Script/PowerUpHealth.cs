using UnityEngine;

public class PowerUpHealth : MonoBehaviour
{
    [SerializeField] GameObject IW_Health;
    [SerializeField] bool FullHealth;
    public GameObject player;
    public Player_Control playerHealth;
    public int extraHealth;
    public GameObject animatorObject;
    public PowerUpIconAnimator animator;
    public HealthDisplay healthDisplay;

    public float HealthTimer;

    public void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<Player_Control>();
        animatorObject = GameObject.FindGameObjectWithTag("Animator");
        animator = animatorObject.GetComponent<PowerUpIconAnimator>();
        
        FullHealth = healthDisplay.fullHealth;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            playerHealth.playercurrentHealth += extraHealth;
            playerHealth.health.ChangeHealth(playerHealth.playercurrentHealth);
            animator.HealthAnimation();
            //IW_Health.SetActive(false);
            Destroy(gameObject);
        }
    }

    public void FixedUpdate()
    {
        HealthTimer += Time.deltaTime;

        if (HealthTimer > 5)
        {
            Destroy(gameObject);
        }
    }
}

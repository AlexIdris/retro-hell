using UnityEngine;

public class PowerUpHealth : MonoBehaviour
{
    [SerializeField] GameObject IW_Health;
    public GameObject player;
    public Player_Control playerHealth;
    public int extraHealth;
    public GameObject animatorObject;
    public PowerUpIconAnimator animator;
    public HealthDisplay healthDisplay;
    [SerializeField] float timer;

    public float timer;

    public void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<Player_Control>();


        healthDisplay = player.GetComponent<HealthDisplay>();
        bool FullHealth = healthDisplay.fullHealth;
    }

    public void Start()
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
            IW_Health.SetActive(false);
            Destroy(gameObject);
        }
    }

    public void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer > 5)
        {
            Destroy(gameObject);
        }
    }
}

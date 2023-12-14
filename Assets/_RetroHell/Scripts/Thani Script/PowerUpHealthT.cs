using UnityEngine;

public class PowerUpHealthT : MonoBehaviour
{
    [SerializeField] GameObject IW_Health;
    [SerializeField] AudioSource audioSource;
    [SerializeField] GameObject DropCollision;
    public GameObject player;
    public Player_Control playerHealth;
    public int extraHealth;
    public GameObject animatorObject;
    public PowerUpIconAnimator animator;
    public HealthDisplay healthDisplay;

    public void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<Player_Control>();

        bool FullHealth = healthDisplay.fullHealth;
    }

    public void Start()
    {
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

            IW_Health.SetActive(false);
            Destroy(gameObject);

        }
    }
    private void OnDestroy()
    {
        audioSource.Play();
    }
}

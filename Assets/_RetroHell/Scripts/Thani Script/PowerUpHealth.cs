using UnityEngine;

public class PowerUpHealth : MonoBehaviour
{


    public GameObject player;
    public Player_Control playerHealth;
    public int extraHealth;
    public GameObject animatorObject;
    public PowerUpIconAnimator animator;
    public HealthDisplay healthDisplay;
    [SerializeField] AudioSource audioSource;
    public float HealthTimer;
    [SerializeField] float dispawntimer = 10;

    public void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<Player_Control>();
        animatorObject = GameObject.FindGameObjectWithTag("Animator");
        animator = animatorObject.GetComponent<PowerUpIconAnimator>();
        bool FullHealth = healthDisplay.fullHealth;

    }
    private void Start()
    {
        HealthTimer = 0;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {

            playerHealth.playercurrentHealth += extraHealth;

            playerHealth.health.ChangeHealth(playerHealth.playercurrentHealth);
            animator.HealthAnimation();
            audioSource.Play();
            Destroy(gameObject);
        }
    }

    public void Update()
    {
        HealthTimer += Time.deltaTime;


        if (HealthTimer > dispawntimer)
        {
            Destroy(gameObject);
        }
    }
}

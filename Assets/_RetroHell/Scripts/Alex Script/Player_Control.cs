using System.Threading.Tasks;
using UnityEngine;

public class Player_Control : MonoBehaviour
{
    public TakingDamageEffect takingDamageEffect;
    [SerializeField] GameObject pp_Volume;
    [SerializeField] GameObject defeatPanel;

    public AudioSource DamageAudioSource;
    [SerializeField] float speed;
    [SerializeField] float jump;
    [SerializeField] float Gravity;
    private string Ground = "Ground";
    [SerializeField] bool isGrounded;
    [SerializeField] Rigidbody rb;
    [SerializeField] Animator anim;
    [SerializeField] CharacterController controller;
    private Vector3 velocity;
    [SerializeField] GameObject gun;
    public int maxHealth;
    public int playercurrentHealth;
    // public ScreenShake shakeDetector;
    public HealthDisplay health;

    private void Awake()
    {
        gun.SetActive(true);
    }
    private void Start()
    {
        defeatPanel.SetActive(false);
        rb = GetComponent<Rigidbody>();
        maxHealth = 100;
        playercurrentHealth = maxHealth;
        health.MaxHealth(maxHealth);
        isGrounded = true;
        pp_Volume.SetActive(true);
        DamageAudioSource.Stop();

    }

    void Update()
    {
        Movement();
        Jump();
        Crouch();

        if (playercurrentHealth <= 0)
        {
            Respawn();
        }

        /*if (isCooldown)
        {
            cooldownTimer -= Time.deltaTime;

          if (playercurrentHealth > maxHealth)
        {
            playercurrentHealth = maxHealth;
        }
            }
        */


    }
    void Movement()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");
        _ = new Vector3(horizontalInput, 0, verticalInput).normalized;
        rb.velocity = speed * verticalInput * gun.transform.forward + horizontalInput * speed * gun.transform.right;
        controller.Move(speed * Time.deltaTime * rb.velocity + velocity * Time.deltaTime);
    }

    void Jump()
    {
        if (Input.GetButton("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jump * -2 * Gravity);

        }
        isGrounded = controller.isGrounded;

        if (isGrounded && velocity.y < 0)
        {

            velocity.y = -2f;
        }
        velocity.y += Gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
    void Crouch()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            anim.SetBool("crouch", true);

        }

        else
        {
            anim.SetBool("crouch", false);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag is "EnemyBullets")
        {

            DamageAudioSource.Play();
            TakeDamage(10);

        }
        if (other.tag is "BlueBullets")
        {

            DamageAudioSource.Play();
            TakeDamage(10);

        }

        else if (other.tag is "Boss")
        {
            DamageAudioSource.Play();
            TakeDamage(1);

        }
        else if (other.tag is "Health")
        {
            StartCoroutine(takingDamageEffect.BloodScreenEffect(Color.green));
        }

        else if (other.tag is "BouncingEnemyBullet")
        {
            DamageAudioSource.Play();
            TakeDamage(20);
        }

    }
    async private void OnTriggerStay(Collider other)
    {
        if (other.tag is "Boss" /*&& !isCooldown*/)
        {
            DamageAudioSource.Play();
            TakeDamage(1);
            await Task.Delay(1000);
            if (playercurrentHealth <= 0)
            {
                Respawn();
            }
            /* isCooldown = true;
             cooldownTimer = cooldownTime;*/
        }
        if (other.tag is "DamageBorder")
        {
            DamageAudioSource.Play();
            TakeDamage(2);
            await Task.Delay(3000);
            if (playercurrentHealth <= 0)
            {
                Respawn();
            }
        }
    }


    public void Respawn()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        gun.SetActive(false);
        defeatPanel.SetActive(true);
        Time.timeScale = 0;

    }

    public void TakeDamage(int damage)
    {
        StartCoroutine(takingDamageEffect.BloodScreenEffect(Color.red));
        playercurrentHealth -= damage;
        health.ChangeHealth(playercurrentHealth);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(Ground))
            isGrounded = true;
    }

}

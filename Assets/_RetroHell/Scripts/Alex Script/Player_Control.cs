using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Control : MonoBehaviour
{
    public TakingDamageEffect takingDamageEffect;
    [SerializeField] GameObject pp_Volume;
    /*[SerializeField] float cooldownTime = 5f;
    [SerializeField] float cooldownTimer = 0f;
    [SerializeField] bool isCooldown = true;*/
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
    private void Start()
    {
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

            if (cooldownTimer <= 0)
            {
                anim.SetBool("crouch", false);
                isCooldown = false;
                cooldownTimer = 0f;
          if (playercurrentHealth > maxHealth)
        {
            playercurrentHealth = maxHealth;
        }
            }
          if (!isCooldown)
                {
                    Crouch();



                }*/


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
            /*isCooldown = true;
            cooldownTimer = 0f;
*/
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
    private void OnTriggerStay(Collider other)
    {
        if (other.tag is "Boss" /*&& !isCooldown*/)
        {
            DamageAudioSource.Play();
            TakeDamage(1);

            if (playercurrentHealth <= 0)
            {
                Respawn();
            }
            /* isCooldown = true;
             cooldownTimer = cooldownTime;*/
        }
    }


    public void Respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void TakeDamage(int damage)
    {
        StartCoroutine(takingDamageEffect.BloodScreenEffect(Color.red));
        playercurrentHealth -= damage;
        health.ChangeHealth(playercurrentHealth);
        //StartCoroutine(shakeDetector.Shake(0.2f));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(Ground))
            isGrounded = true;
    }

}

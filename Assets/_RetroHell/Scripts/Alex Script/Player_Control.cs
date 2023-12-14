using UnityEngine;

public class Player_Control : MonoBehaviour
{
    public TakingDamageEffect takingDamageEffect;
    [SerializeField] GameObject pp_Volume;
    [SerializeField] float cooldownTime = 1f;
    [SerializeField] float cooldownTimer = 0f;
    [SerializeField] bool isCooldown = true;
    public AudioSource DamageAudioSource;
    public AudioSource HeartBeatAudioSource;
    [SerializeField] GameObject audio;
    [SerializeField] float speed;
    [SerializeField] float jump;
    [SerializeField] float Gravity;
    private string Ground = "Ground";
    [SerializeField] bool isGrounded;
    [SerializeField] Rigidbody rb;
    [SerializeField] Animator anim;
    [SerializeField] CharacterController controller;
    private Vector3 velocity;

    public int maxHealth = 100;
    public int playercurrentHealth;
    public HealthDisplay health;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playercurrentHealth = maxHealth;
        health.MaxHealth(maxHealth);
        isGrounded = true;
        pp_Volume.SetActive(true);
        DamageAudioSource.Stop();
        HeartBeatAudioSource.Stop();

    }

    void Update()
    {
        Movement();
        Jump();
        Crouch();

        if (isCooldown)
        {

            cooldownTimer -= Time.deltaTime;

            if (cooldownTimer <= 0)
            {
                isCooldown = false;
                cooldownTimer = 0f;
            }
        }

        if (playercurrentHealth > maxHealth)
        {
            playercurrentHealth = maxHealth;
        }
        if (playercurrentHealth >= 50)
        {
            audio.SetActive(false);
            HeartBeatAudioSource.Stop();

        }

    }
    void Movement()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;

        rb.velocity = transform.forward * verticalInput * speed + transform.right * horizontalInput * speed;
        float move = rb.velocity.magnitude;

        if (move > 0)
        {
            //anim.SetBool("run", true);
        }
        else
        {
            //anim.SetBool("run", false);
        }
        controller.Move(rb.velocity * speed * Time.deltaTime + velocity * Time.deltaTime);
    }

    void Jump()
    {
        if (Input.GetButton("Jump") && isGrounded)
        {

            // anim.SetBool("jump", true);
            velocity.y = Mathf.Sqrt(jump * -2 * Gravity);

        }
        isGrounded = controller.isGrounded;

        if (isGrounded && velocity.y < 0)
        {
            // anim.SetBool("Jump", false);
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
        if (other.tag == "EnemyBullets")
        {


            DamageAudioSource.Play();
            TakeDamage(10);
            if (playercurrentHealth <= 50)
            {
                audio.SetActive(true);
                HeartBeatAudioSource.Play();

            }

            if (playercurrentHealth <= 0)
            {
                Respawn();
            }

        }
        else if (other.tag == "Boss")
        {
            DamageAudioSource.Play();
            TakeDamage(1);

        }
        else if (other.tag == "BouncingEnemyBullet")
        {
            DamageAudioSource.Play();
            TakeDamage(20);


            if (playercurrentHealth <= 0)
            {
                Respawn();
            }

        }



    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Boss" && !isCooldown)
        {
            DamageAudioSource.Play();
            TakeDamage(1);

            if (playercurrentHealth <= 0)
            {
                Respawn();
            }
            isCooldown = true;
            cooldownTimer = cooldownTime;
        }
    }


    public void Respawn()
    {

        GameManager.Instance.RespawnPlayer();
    }

    public void TakeDamage(int damage)
    {
        playercurrentHealth -= damage;
        health.ChangeHealth(playercurrentHealth);

        StartCoroutine(takingDamageEffect.BloodScreenEffect());
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(Ground))
            isGrounded = true;
    }


}

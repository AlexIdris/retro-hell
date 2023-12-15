using System.Threading.Tasks;
using UnityEngine;

public class Player_Control : MonoBehaviour
{
    public Transform player;
    public Vector3 respawnPosition;
    [SerializeField] bool respawned;

    public TakingDamageEffect takingDamageEffect;
    [SerializeField] GameObject pp_Volume;
    [SerializeField] float cooldownTime = 1f;
    [SerializeField] float cooldownTimer = 0f;
    [SerializeField] bool isCooldown = true;
    public AudioSource DamageAudioSource;
    public AudioSource HeartBeatAudioSource;
    [SerializeField] GameObject Heartaudio;
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
    public ScreenShake shakeDetector;
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


        OnDestroy();


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
            Heartaudio.SetActive(false);
            HeartBeatAudioSource.Stop();

        }

    }
    void Movement()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");
        _ = new Vector3(horizontalInput, 0, verticalInput).normalized;
        rb.velocity = speed * verticalInput * transform.forward + horizontalInput * speed * transform.right;
        float move = rb.velocity.magnitude;

        if (move > 0)
        {
            //anim.SetBool("run", true);
        }
        else
        {
            //anim.SetBool("run", false);
        }
        controller.Move(speed * Time.deltaTime * rb.velocity + velocity * Time.deltaTime);
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
        if (other.tag is "EnemyBullets")
        {


            DamageAudioSource.Play();
            TakeDamage(10);
            if (playercurrentHealth <= 50)
            {
                Heartaudio.SetActive(true);
                HeartBeatAudioSource.Play();

            }

            if (playercurrentHealth <= 0)
            {
                LoadCheckpoint();
                Respawn();
            }

        }
        else if (other.tag is "Boss")
        {
            DamageAudioSource.Play();
            TakeDamage(1);

        } 
        else if (other.tag == "Health")
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
        if (other.tag is "Boss" && !isCooldown)
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

    private async void OnDestroy()
    {
        if (playercurrentHealth <= 0 && respawned == true)
        {
            Respawn();
            await Task.Delay(50);
            playercurrentHealth = maxHealth;
            health.MaxHealth(maxHealth);

        }
    }
    void LoadCheckpoint()
    {
        float posX = PlayerPrefs.GetFloat("PlayerPosX", 0f);
        float posY = PlayerPrefs.GetFloat("PlayerPosY", 0f);
        float posZ = PlayerPrefs.GetFloat("PlayerPosZ", 0f);

        Vector3 playerPosition = new(posX, posY, posZ);
        transform.position = playerPosition;

        Debug.Log("Player position loaded.");
    }
    public void Respawn()
    {
        player.position = respawnPosition;

        Debug.Log("Player respawned!");

        respawned = true;
    }

    public void TakeDamage(int damage)
    {
        StartCoroutine(takingDamageEffect.BloodScreenEffect(Color.red));
        playercurrentHealth -= damage;
        health.ChangeHealth(playercurrentHealth);
        shakeDetector.hit = true;
        //shakeDetector.hit = true;

       

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(Ground))
            isGrounded = true;
    }


}

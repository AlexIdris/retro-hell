using UnityEngine;

public class Player_Control : MonoBehaviour
{
    public float speed;
    public float jump;

    private string Ground = "Ground";
    private Rigidbody rb;
    [SerializeField] Animator anim;

    private bool isGrounded = true;

    [SerializeField] int maxHealth = 500;
    public int currentHealth;
    public HealthDisplay health;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentHealth = maxHealth;
        health.MaxHealth(maxHealth);
    }

    void Update()
    {
        Movement();
        Jump();
        Crouch();

    }
    void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;

        rb.velocity = moveDirection * speed;
        float velocityMagnitude = rb.velocity.magnitude;

        if (velocityMagnitude > 0)
        {
            anim.SetBool("run", true);
        }
        else
        {
            anim.SetBool("run", false);
        }

    }

    void Jump()
    {
        if (Input.GetButton("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
            anim.SetBool("jump", true);
            isGrounded = false;
        }
        else
        {
            anim.SetBool("jump", false);
        }
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
        if (other.tag == "Enemy Bullet")
        {
            TakeDamage(10);
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        health.ChangeHealth(currentHealth);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(Ground))
            isGrounded = true;
    }

}

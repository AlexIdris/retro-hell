using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Control : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jump;
    [SerializeField] float Gravity;
    private string Ground = "Ground";
    [SerializeField] bool isGrounded;
    [SerializeField] Rigidbody rb;
    [SerializeField] Animator anim;
    [SerializeField] CharacterController controller;
    private Vector3 velocity;

    [SerializeField] int maxHealth = 500;
    public int playercurrentHealth;
    public HealthDisplay health;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playercurrentHealth = maxHealth;
        health.MaxHealth(maxHealth);
        isGrounded = true;
    }

    void Update()
    {
        Movement();
        Jump();
        Crouch();

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
            anim.SetBool("run", true);
        }
        else
        {
            anim.SetBool("run", false);
        }
        controller.Move(rb.velocity * speed * Time.deltaTime + velocity * Time.deltaTime);
    }

    void Jump()
    {
        if (Input.GetButton("Jump") && isGrounded)
        {

            anim.SetBool("jump", true);
            velocity.y = Mathf.Sqrt(jump * -2 * Gravity);

        }
        isGrounded = controller.isGrounded;

        if (isGrounded && velocity.y < 0)
        {
            anim.SetBool("Jump", false);
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
            TakeDamage(10);
            if (playercurrentHealth <= 0)
            {
                OnDeath();
            }
        }

    }
    void OnDeath()
    {
        SceneManager.LoadScene(1);
    }
    public void TakeDamage(int damage)
    {
        playercurrentHealth -= damage;
        health.ChangeHealth(playercurrentHealth);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(Ground))
            isGrounded = true;
    }

}

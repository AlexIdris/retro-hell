using UnityEngine;

public class Player_Control : MonoBehaviour
{
    public float speed;

    public float jump;

    private string Ground = "Ground";
    private Rigidbody rb;
    [SerializeField] Animator anim;

    private bool isGrounded = true;
    private CharacterController _characterController;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        _characterController = GetComponent<CharacterController>();

    }

    void Update()
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

        if (Input.GetKey(KeyCode.LeftControl))
        {
            anim.SetBool("crouch", true);

        }
        else
        {
            anim.SetBool("crouch", false);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(Ground))
            isGrounded = true;
    }

}

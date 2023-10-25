using UnityEngine;

public class Player_Control : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
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


        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("run", true);
            rb.velocity = new Vector3(x: speed, y: 0, z: 0);


        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("run", true);
            rb.velocity = new Vector3(x: -speed, y: 0, z: 0);

        }
        else if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("run", true);
            rb.velocity = new Vector3(x: 0, y: 0, z: speed);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("run", true);
            rb.velocity = new Vector3(x: 0, y: 0, z: -speed);

        }
        else
        {
            anim.SetBool("run", false);
        }
        float rotationX = Input.GetAxis("Mouse X");
        transform.Rotate(rotationX * Vector3.up, turnSpeed * Time.deltaTime);



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

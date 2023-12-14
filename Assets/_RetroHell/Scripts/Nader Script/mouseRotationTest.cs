using UnityEngine;

public class mouseRotationTest : MonoBehaviour
{
    [SerializeField] public float Speed = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Mouse X");
        transform.Rotate(0, horizontal * Speed * Time.deltaTime, 0);
        /*   float Vertical = Input.GetAxis("Mouse Y");

           Vertical = Mathf.Clamp(Vertical, -10, 10);*/

        // transform.Rotate(Vertical * Speed * Time.deltaTime, 0, 0);



    }
}

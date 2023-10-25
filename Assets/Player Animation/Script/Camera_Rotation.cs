using UnityEngine;

public class Camera_Rotation : MonoBehaviour
{
    public float turnSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float rotationX = Input.GetAxis("Mouse X");
        transform.Rotate(rotationX * Vector3.up, turnSpeed * Time.deltaTime);
    }
}

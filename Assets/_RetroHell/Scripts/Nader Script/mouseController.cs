using UnityEngine;

public class mouseController : MonoBehaviour
{
    [SerializeField] float Speed = 1000;
    [SerializeField] GameObject gun;
    [SerializeField] float maxRotation = 50f;
    [SerializeField] float minRotation = -50f;
    [SerializeField] float X;
    [SerializeField] float Y;
    private void Update()
    {
        X -= Speed * Input.GetAxis("Mouse Y");
        Y += Speed * Input.GetAxis("Mouse X");
        X = Mathf.Clamp(X, minRotation, maxRotation);
        transform.eulerAngles = new Vector3(X, Y, 0f);
        gun.transform.eulerAngles = new Vector3(X, Y, 0f);


    }
}
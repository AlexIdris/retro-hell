using UnityEngine;

public class mouseController : MonoBehaviour
{
    public float Speed = 1000;
    [SerializeField] GameObject gun;
    [SerializeField] PauseSystem pauseSystem;
    [SerializeField] float maxRotation = 50f;
    [SerializeField] float minRotation = -50f;
    [SerializeField] float X;
    [SerializeField] float Y;


    public void Update()
    {
        X -= Speed * Input.GetAxis("Mouse Y");
        Y += Speed * Input.GetAxis("Mouse X");
        X = Mathf.Clamp(X, minRotation, maxRotation);

        transform.eulerAngles = new Vector3(X, Y, 0f);
        gun.transform.eulerAngles = new Vector3(X, Y, 0f);
    }


}
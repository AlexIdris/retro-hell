using UnityEngine;

public class turretRotation : MonoBehaviour
{


    public float rotationDelay = 1f;
    private bool rotating = false;
    [SerializeField] private float speed = 10;

    void Update()
    {
        if (Time.time >= rotationDelay && !rotating)
        {
            RotateTurret();
        }
    }
    public void RotateTurret()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }



}
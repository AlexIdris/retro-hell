using UnityEngine;

public class turretRotation : MonoBehaviour
{

    public float speed = 10;
    public float rotationDelay = 1f;
    private bool rotating = false;


    void Update()
    {
        if (Time.time >= rotationDelay && !rotating)
        {
            RotateTurret();
        }
    }
    public void RotateTurret()
    {
        transform.Rotate(0, speed, 0);
    }



}
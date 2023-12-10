using UnityEngine;

public class turretRotation : MonoBehaviour
{
    public float speed = 10;
    public float rotationDelay = 0.5f;
    public float rotateValue;

    private bool rotating = false;

    public PauseSystem pause;

    void FixedUpdate()
    {
        if (Time.time >= rotationDelay && !rotating && pause.gamePaused == false)
        {
            RotateTurret();
        }
    }

    public void RotateTurret()
    {
        transform.Rotate(0, speed, 0);
        rotateValue += speed;
    }
}
using UnityEngine;

public class turretRotation : MonoBehaviour
{
    public float speed = 0.1f;
    public float rotationDelay = 0.5f;
    public float speedlimit = 3f;
    public float rotationDelaylimit = 5;
    public float rotateValue;
    [SerializeField] float cooldownTime = 5f;
    [SerializeField] float cooldownTimer = 5f;
    [SerializeField] bool isCooldown = true;
    private bool rotating = false;
    [SerializeField] float loop;
    [SerializeField] float difficultyincrease = 0.1f;
    public PauseSystem pause;

    void FixedUpdate()
    {
        if (Time.time >= rotationDelay && !rotating && pause.gamePaused == false)
        {
            RotateTurret();
            if (isCooldown)
            {

                cooldownTimer -= Time.deltaTime;

                if (cooldownTimer <= 0)
                {
                    isCooldown = false;
                    cooldownTimer = 0f;
                }
            }
            if (speed > speedlimit && rotationDelay > rotationDelaylimit)
            {
                isCooldown = true;
            }
            if (!isCooldown)
            {
                speed += difficultyincrease;
                rotationDelay += difficultyincrease;
                loop = 0;
                isCooldown = true;
                cooldownTimer = cooldownTime;
            }

        }
    }

    public void RotateTurret()
    {
        transform.Rotate(0, speed, 0);
        rotateValue += speed;
    }
}
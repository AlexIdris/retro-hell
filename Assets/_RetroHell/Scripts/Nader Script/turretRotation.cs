using UnityEngine;

public class turretRotation : MonoBehaviour
{




    public float rotationDelay = 1f;
    private bool rotating = false;
    private void Start()
    {

    }
    void Update()
    {
        if (Time.time >= rotationDelay && !rotating)
        {
            RotateTurret();
        }


    }
    public void RotateTurret()
    {
        transform.Rotate(0, 1, 0);
    }



}
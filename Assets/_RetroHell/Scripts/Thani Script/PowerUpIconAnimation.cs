using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpIconAnimation : MonoBehaviour
{
    public float angleTurn = 10;
    public int spin = 0;

    public GameObject spawnPoint;

    public void Start()
    {
        spawnPoint = GameObject.FindGameObjectWithTag("Animator");
    }

    void FixedUpdate()
    {
        transform.position = spawnPoint.transform.position;
        transform.Rotate(0, angleTurn, 0);
        spin += 1;

        if (spin > 36)
        {
            Destroy(gameObject);
        }
    }
}

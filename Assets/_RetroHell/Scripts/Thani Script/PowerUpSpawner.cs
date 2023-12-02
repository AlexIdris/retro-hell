using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public List<GameObject> PowerUps;

    public float timer;
    public int randomPowerUp;

    public void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer > 5)
        {
            randomPowerUp = Random.Range(0, PowerUps.Count);

            Vector3 position = new Vector3(Random.Range(-15,16), 0, Random.Range(-15, 16));
            Instantiate(PowerUps[randomPowerUp], position, Quaternion.identity);

            timer = 0;
        }
    }
}

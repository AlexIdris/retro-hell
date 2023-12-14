using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public List<GameObject> PowerUps;

    [SerializeField] float timer;
    [SerializeField] float nexttimer;
    public int randomPowerUp;

    public void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer >= nexttimer)
        {
            randomPowerUp = Random.Range(0, 2);

            Vector3 position = new Vector3(Random.Range(-30, 30), -1, Random.Range(-30, 30) - 1);
            Instantiate(PowerUps[randomPowerUp], position, Quaternion.identity);
            timer = 0;
        }
    }
}

using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public List<GameObject> PowerUps;

    public float timer;
    public int PowerUpList = 0;
    public int randomPowerUp = 0;
    public int randomPosition;

    public void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer >= nexttimer)
        {
            randomPowerUp = Random.Range(0, 10);
            randomPosition = Random.Range(0, 4);

            if (randomPowerUp > 5)
            {
                PowerUpList = 1;
            } else {
                PowerUpList = 0;
            }

            Debug.Log(randomPowerUp);
            Debug.Log(PowerUpList);

            if (randomPosition == 0)
            {
                Vector3 position = new Vector3(Random.Range(28, 30), -1, Random.Range(-30, 30));
                Instantiate(PowerUps[PowerUpList], position, Quaternion.identity);
                timer = 0;
            }

            if (randomPosition == 1)
            {
                Vector3 position = new Vector3(Random.Range(-30, 30), -1, Random.Range(28, 30));
                Instantiate(PowerUps[PowerUpList], position, Quaternion.identity);
                timer = 0;
            }

            if (randomPosition == 2)
            {
                Vector3 position = new Vector3(Random.Range(-28, -30), -1, Random.Range(-30, 30));
                Instantiate(PowerUps[PowerUpList], position, Quaternion.identity);
                timer = 0;
            }

            if (randomPosition == 3)
            {
                Vector3 position = new Vector3(Random.Range(-30, 30), -1, Random.Range(-28, -30));
                Instantiate(PowerUps[PowerUpList], position, Quaternion.identity);
                timer = 0;
            }
        }
    }
}

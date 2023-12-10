using System.Collections.Generic;
using System.Threading.Tasks;
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
            randomPowerUp = Random.Range(0, 2);

            Vector3 position = new Vector3(Random.Range(-30, 30), 0, Random.Range(-30, 30));
            Instantiate(PowerUps[randomPowerUp], position, Quaternion.identity);
            timer = 0;
        }
    }
}

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
        Spawner();
    }

    async void Spawner()
    {
        timer += Time.deltaTime;

        if (timer > 5 && timer < 5.2)
        {
            randomPowerUp = Random.Range(0, PowerUps.Count);

            Vector3 position = new Vector3(Random.Range(-20, 20), 0, Random.Range(-20, 20));
            Instantiate(PowerUps[randomPowerUp], position, Quaternion.identity);
            await Task.Delay(3000);
            timer = 0;
        }
        await Task.Delay(5000);
        DestroyImmediate(PowerUps[randomPowerUp], true);

    }
}

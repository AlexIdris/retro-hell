using UnityEngine;

public class Minnion_Spawner : MonoBehaviour
{
    [SerializeField] float nextFireTime = 0f;
    [SerializeField] float fireRate = 1.0f;
    [SerializeField] GameObject[] MinnionArray;
    int spawnType;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFireTime)
        {
            MinnionSpawn();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }
    void MinnionSpawn()
    {
        spawnType = Random.Range(0, MinnionArray.Length);
        Instantiate(MinnionArray[spawnType], transform.position, Quaternion.identity);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy Bullet")
        {
            Destroy(other.gameObject);
        }
    }
}

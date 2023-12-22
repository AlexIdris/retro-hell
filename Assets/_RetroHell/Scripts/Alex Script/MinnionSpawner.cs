using UnityEngine;

public class MinnionSpawner : MonoBehaviour
{
    [SerializeField] float nextFireTime = 0f;
    [SerializeField] float fireRate = 1.0f;
    [SerializeField] GameObject[] minnionArray;
    int spawnType;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time > nextFireTime)
        {
            MinnionSpawn();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }
    void MinnionSpawn()
    {
        spawnType = Random.Range(0, minnionArray.Length);
        Instantiate(minnionArray[spawnType], transform.position, Quaternion.identity);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy Bullet")
        {
            Destroy(other.gameObject);
        }
    }
}

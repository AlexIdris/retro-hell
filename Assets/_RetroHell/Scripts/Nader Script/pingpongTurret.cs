using UnityEngine;

public class pingpongTurret : MonoBehaviour
{
    [SerializeField] float minDistance = 2;
    [SerializeField] float maxDistance = 2;
    [SerializeField] float speed = 3;

    void Update()
    {
        float yAxis = Mathf.PingPong(Time.time * speed, maxDistance + minDistance);
        transform.position = new Vector3(transform.position.x, yAxis, transform.position.z);
    }
}

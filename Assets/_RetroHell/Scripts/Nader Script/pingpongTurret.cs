using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pingpongTurret : MonoBehaviour
{
    [SerializeField] float minDistance = 5;
    [SerializeField] float maxDistance = 10;
    [SerializeField] float speed = 3;

    void Update()
    {
        float yAxis = Mathf.PingPong(Time.time * speed, maxDistance - minDistance);
        transform.position = new Vector3(transform.position.x, yAxis, transform.position.z);
    }
}

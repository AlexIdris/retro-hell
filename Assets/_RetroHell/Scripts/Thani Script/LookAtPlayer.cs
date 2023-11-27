using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public GameObject target;

    public float rotationFreezeX = 0;
    public float rotationFreezeY = 0;

    void FixedUpdate()
    {
        transform.position = transform.position;
        transform.rotation = Quaternion.LookRotation(target.transform.position - transform.position, transform.up);
    }
}

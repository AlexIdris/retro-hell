using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public GameObject target;
    public float rotationStopperX = 90;
    public float rotationStopperZ = 0;

    public void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    void FixedUpdate()
    {
        transform.rotation = Quaternion.LookRotation(target.transform.position - transform.position);

        Vector3 eulerAngles = transform.eulerAngles;
        transform.eulerAngles = new Vector3(-rotationStopperX, eulerAngles.y, rotationStopperZ);
    }
}

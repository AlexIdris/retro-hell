using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPhysics : MonoBehaviour
{
    public float timeAwake;

    private void FixedUpdate()
    {
        timeAwake += Time.deltaTime;

        if (timeAwake >= 0.5)
        {
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}

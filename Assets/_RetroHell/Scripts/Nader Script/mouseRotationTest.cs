using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseRotationTest : MonoBehaviour
{
    [SerializeField] public float Speed = 1;


    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Mouse X");
        transform.Rotate(0,horizontal*Speed*Time.deltaTime, 0);
    }
}

using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

public class mouseRotationTest : MonoBehaviour
{
    [SerializeField] public float Speed = 1;


    void Update()
    {
        float horizontal = Input.GetAxis("Mouse X");
        transform.Rotate(0, horizontal * Speed * Time.deltaTime, 0);

        /*float Vertical = Input.GetAxis("Mouse Y");
        transform.Rotate(Vertical * Speed * Time.deltaTime, 0, 0);*/
    }
}

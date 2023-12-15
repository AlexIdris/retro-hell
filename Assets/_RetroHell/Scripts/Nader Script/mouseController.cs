using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseController : MonoBehaviour
{
    [SerializeField] float Speed = 1;
    private void Update()
    {
        float Vertical = Input.GetAxis("Mouse Y");
        transform.Rotate(-Vertical * Speed * Time.deltaTime, 0, 0);
    }
}
    

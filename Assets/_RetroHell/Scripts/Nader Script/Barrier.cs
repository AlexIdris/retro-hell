using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Barrier : MonoBehaviour
{
   public void OnTriggerEnter(Collider other)
   {
        Debug.Log("AAAAAAAAAA");
        if(other.gameObject.CompareTag("Bullets"))
        {
            Destroy(other.gameObject);
        }
   }
}

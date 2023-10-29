using UnityEngine;

public class Barrier : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        {

            if (collision.gameObject.CompareTag("Bullets"))
            {
                Destroy(collision.gameObject);
            }
        }
    }

}

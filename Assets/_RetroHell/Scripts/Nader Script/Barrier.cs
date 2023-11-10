using UnityEngine;

public class Barrier : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        {

            if (collision.gameObject.CompareTag("Enemy Bullet"))
            {
                Destroy(collision.gameObject);
            }
        }
    }

}

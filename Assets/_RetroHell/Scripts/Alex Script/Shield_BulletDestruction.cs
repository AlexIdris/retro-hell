using UnityEngine;

public class Shield_BulletDestruction : MonoBehaviour
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

using UnityEngine;

public class ShieldBulletDestruction : MonoBehaviour
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

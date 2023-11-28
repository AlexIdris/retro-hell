using UnityEngine;

public class Barrier : MonoBehaviour
{
    public void OnTriggeer(Collision collider)
    {
        {

            if (collider.gameObject.CompareTag("EnemyBullets"))
            {
                Destroy(collider.gameObject);
            }

            if (collider.gameObject.CompareTag("Bullets"))
            {
                Destroy(collider.gameObject);
            }
        }
    }
}

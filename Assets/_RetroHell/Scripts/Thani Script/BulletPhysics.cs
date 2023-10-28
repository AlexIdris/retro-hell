using UnityEngine;

public class BulletPhysics : MonoBehaviour
{
    public float timeAwake;

    private void FixedUpdate()
    {
        timeAwake += Time.deltaTime;

        if (timeAwake >= 3)
        {
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}

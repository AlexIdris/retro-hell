using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform player;
    public float distance = 5.0f;
    public float height = 2.0f;
    public float speed = 5.0f;
    public float magnitude = 1f;
    void LateUpdate()
    {
        Vector3 CameraPosition = player.transform.position + Vector3.up * height - player.transform.forward * distance;
        transform.position = Vector3.Lerp(transform.position, CameraPosition, speed * Time.deltaTime);
        transform.LookAt(player.transform.position);
    }
}

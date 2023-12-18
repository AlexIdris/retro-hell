using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform player;
    public float distance = 5.0f;
    public float height = 2.0f;
    public float speed = 5.0f;
    public float zoomSpeed = 2.0f;
    public float maxZoom = 5.0f;
    public float minZoom = 1.0f;


    void LateUpdate()
    {
        Vector3 CameraPosition = player.transform.position + Vector3.up * height - player.transform.forward * distance;
        transform.position = Vector3.Lerp(transform.position, CameraPosition, speed * Time.deltaTime);
        transform.LookAt(player.transform.position);

    }

    void Update()
    {
        /*RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxZoom))
        {

            float targetZoom = Mathf.Clamp(hit.distance, minZoom, maxZoom);


            Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, targetZoom, Time.deltaTime * zoomSpeed);
        }
        else
        {

            Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, 60f, Time.deltaTime * zoomSpeed);
        }*/
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public Transform boss;

    public float minimumDistance = 10f;
    public float maximumDistance = 50f;
    public float smoothness = 0.5f;

    private Vector3 velocity = Vector3.zero;
    private Camera cam;

    public void Start()
    {
        cam = GetComponent<Camera>();
    }

    public void LateUpdate()
    {
        if (player == null || boss == null)
        {
            return;
        }

        Vector3 midpoint = (player.position + boss.position) / 2;
        float distance = Vector3.Distance(player.position, boss.position);
        float cameraDistance = Mathf.Lerp(minimumDistance, maximumDistance, distance / maximumDistance);
        Vector3 cameraTarget = midpoint - cam.transform.forward * distance;

        cam.transform.position = Vector3.SmoothDamp(cam.transform.position, cameraTarget, ref velocity, smoothness);
    }
}

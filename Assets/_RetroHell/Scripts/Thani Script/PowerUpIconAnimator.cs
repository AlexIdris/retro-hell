using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpIconAnimator : MonoBehaviour
{
    public GameObject HealthIcon;
    public GameObject MGIcon;
    public Transform spawnPoint;

    public void HealthAnimation()
    {
        Instantiate(HealthIcon, spawnPoint.position, spawnPoint.rotation);
    }

    public void MGAnimation()
    {
        Instantiate(MGIcon, spawnPoint.position, spawnPoint.rotation);
    }
}

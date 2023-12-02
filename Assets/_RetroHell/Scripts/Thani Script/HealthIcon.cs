using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthIcon : MonoBehaviour
{
    public int maxHealth = 100;
    public int minHealth = 0;

    public float maxScale = 1f;
    public float minScale = 0f;

    public GameObject heart;
    public GameObject player;
    public Player_Control playerControl;

    public float currentScale;

    public void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerControl = player.GetComponent<Player_Control>();

    }

    public void FixedUpdate()
    {
        currentScale = Mathf.Lerp(minScale, maxScale, Mathf.InverseLerp(minHealth, maxHealth, playerControl.playercurrentHealth));
        heart.transform.localScale = new Vector3(currentScale, currentScale, currentScale);
    }
}
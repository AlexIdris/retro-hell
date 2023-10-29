using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthDisplay : MonoBehaviour
{
    public static int health;
    Text healthCounter;

    private void Start()
    {
        health = 100;
        healthCounter = GetComponent<Text>();
    }

    private void Update()
    {
        healthCounter.text = health.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public static int health;
    Text healthCounter;

    void Start()
    {
        healthCounter = GetComponent<Text>();
    }

    void Update()
    {
        healthCounter.text = health.ToString();
    }
}

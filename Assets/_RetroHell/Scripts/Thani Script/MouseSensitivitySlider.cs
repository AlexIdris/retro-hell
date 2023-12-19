using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseSensitivitySlider : MonoBehaviour
{
    public mouseController mouseSpeed;
    public Slider slider;

    void Start()
    {
        slider.value = slider.maxValue;
        mouseSpeed.Speed = slider.value;
    }

    void Update()
    {
        mouseSpeed.Speed = slider.value;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SFXController : MonoBehaviour
{
    public AudioMixer SFXmixer;

    public void ChangeVolume (float sliderValue)
    {
        SFXmixer.SetFloat ("SFX Param", Mathf.Log10(sliderValue) * 20);
    }
}

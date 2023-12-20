using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class InGameAudioController : MonoBehaviour
{
    public AudioMixer IGAmixer;

    public void ChangeVolume (float sliderValue)
    {
        IGAmixer.SetFloat ("In-Game Param", Mathf.Log10(sliderValue) * 20);
    }
}

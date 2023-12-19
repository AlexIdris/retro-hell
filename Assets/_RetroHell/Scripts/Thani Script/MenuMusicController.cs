using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuMusicController : MonoBehaviour
{
    public AudioMixer MMmixer;

    public void ChangeVolume (float sliderValue)
    {
        MMmixer.SetFloat ("Menu Param", Mathf.Log10(sliderValue) * 20);
    }
}

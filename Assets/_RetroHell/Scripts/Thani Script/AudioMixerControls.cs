using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioMixerControls : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider musicAudioSlider;
    [SerializeField] private Slider ingameAudioSlider;
    [SerializeField] private Slider SFXAudioSlider;

    public void Start()
    {
        if (PlayerPrefs.HasKey("Volume"))
        {
            LoadVolume();
        }
        else
        {
            ChangeMMusicVolume();
            ChangeIGMusicVolume();
            ChangeSFXVolume();
        }
    }

    public void ChangeMMusicVolume()
    {
        float volume = musicAudioSlider.value;
        audioMixer.SetFloat("Menu Music", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("MMVolume", volume);
    }

    public void ChangeIGMusicVolume()
    {
        float volume = ingameAudioSlider.value;
        audioMixer.SetFloat("In-Game Music", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("IGMVolume", volume);
    }

    public void ChangeSFXVolume()
    {
        float volume = SFXAudioSlider.value;
        audioMixer.SetFloat("Sound Effects", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("SFXVolume", volume);
    }

    public void LoadVolume()
    {
        musicAudioSlider.value = PlayerPrefs.GetFloat("MMVolume");
        ingameAudioSlider.value = PlayerPrefs.GetFloat("IGMVolume");
        SFXAudioSlider.value = PlayerPrefs.GetFloat("SFXVolume");

        ChangeMMusicVolume();
        ChangeIGMusicVolume();
        ChangeSFXVolume();
    }
}

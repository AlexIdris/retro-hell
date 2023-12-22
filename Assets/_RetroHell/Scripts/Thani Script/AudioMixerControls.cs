using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioMixerControls : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider musicAudioSlider;


    public void Start()
    {
        if (PlayerPrefs.HasKey("Volume"))
        {
            LoadVolume();
        }
        else
        {
            ChangeMMusicVolume();

        }
    }

    public void ChangeMMusicVolume()
    {
        float volume = musicAudioSlider.value;
        audioMixer.SetFloat("Menu Music", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("MMVolume", volume);
    }


    public void LoadVolume()
    {
        musicAudioSlider.value = PlayerPrefs.GetFloat("MMVolume");

        ChangeMMusicVolume();

    }
}

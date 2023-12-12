using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public Slider menuVolumeSlider;
    public AudioSource menuAudioSource;


    void Start()
    {
        menuVolumeSlider.value = menuVolumeSlider.maxValue;
        menuAudioSource.volume = menuVolumeSlider.value;

        // Add a listener to the slider
        menuVolumeSlider.onValueChanged.AddListener(ChangeVolume);
    }

    void ChangeVolume(float volume)
    {
        // Update the audio source volume
        menuAudioSource.volume = volume;
    }
}

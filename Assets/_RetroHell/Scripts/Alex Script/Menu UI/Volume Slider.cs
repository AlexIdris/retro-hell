using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioSource audioSource;

    void Start()
    {
        volumeSlider.value = volumeSlider.maxValue;
        audioSource.volume = volumeSlider.value;

        // Add a listener to the slider
        volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }

    void ChangeVolume(float volume)
    {
        // Update the audio source volume
        audioSource.volume = volume;
    }
}

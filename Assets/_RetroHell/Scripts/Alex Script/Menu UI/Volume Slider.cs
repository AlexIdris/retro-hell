using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    public AudioSource audioSource4;
    public AudioSource audioSource5;

    void Start()
    {
        volumeSlider.value = volumeSlider.maxValue;
        audioSource1.volume = volumeSlider.value;
        audioSource2.volume = volumeSlider.value;
        audioSource3.volume = volumeSlider.value;
        audioSource4.volume = volumeSlider.value;
        audioSource5.volume = volumeSlider.value;

        // Add a listener to the slider
        volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }

    public void ChangeVolume(float volume)
    {
        // Update the audio source volume
        audioSource1.volume = volume;
        audioSource2.volume = volume;
        audioSource3.volume = volume;
        audioSource4.volume = volume;
        audioSource5.volume = volume;
    }
}

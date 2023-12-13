using UnityEngine;

public class Audio : MonoBehaviour
{

    [SerializeField] private AudioClip settingsAudioClip;

    private void Start()
    {
        DoNotDelete notDelete = FindObjectOfType<DoNotDelete>();

        if (notDelete != null && settingsAudioClip != null)
        {
            notDelete.Music(settingsAudioClip);
        }

    }
}

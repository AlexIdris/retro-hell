using UnityEngine;

public class GameStart : MonoBehaviour
{
    [SerializeField] AudioSource tutorailAudio;
    [SerializeField] AudioSource ingameAudio;

    private void Start()
    {
        tutorailAudio.Play();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag is "Player")
        {
            tutorailAudio.Stop();
            ingameAudio.Play();
            Destroy(gameObject);
        }

    }

}

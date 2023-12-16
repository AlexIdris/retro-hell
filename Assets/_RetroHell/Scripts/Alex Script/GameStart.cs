using UnityEngine;

public class GameStart : MonoBehaviour
{
    [SerializeField] AudioSource TutorailAudio;
    [SerializeField] AudioSource IngameAudio;

    private void Start()
    {
        TutorailAudio.Play();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorailAudio.Stop();
            IngameAudio.Play();
            Destroy(gameObject);
        }

    }

}

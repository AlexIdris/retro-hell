using UnityEngine;

public class GameStart : MonoBehaviour
{
    [SerializeField] GameObject TutorailAudio;
    [SerializeField] GameObject IngameAudio;

    private void Start()
    {
        TutorailAudio.SetActive(true);
        IngameAudio.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorailAudio.SetActive(false);
            IngameAudio.SetActive(true);
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorailAudio.SetActive(false);
            IngameAudio.SetActive(true);
        }
    }
}

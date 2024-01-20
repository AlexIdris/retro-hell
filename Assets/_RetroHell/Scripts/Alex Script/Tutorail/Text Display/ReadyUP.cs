using TMPro;
using UnityEngine;

public class ReadyUP : MonoBehaviour
{
    [SerializeField] TMP_Text tutorText;
    [SerializeField] GameObject frame;
    [SerializeField] GameObject tutorailPopups;
    [SerializeField] AudioSource robotAudioSource;
    private void Awake()
    {
        tutorailPopups.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);
            robotAudioSource.Play();
            tutorText.text = "You actually killed it?! Sigh...I guess I lost\n" +
                "You may now proceed to the arena";

        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);

            tutorText.gameObject.SetActive(true);
            robotAudioSource.Play();
            tutorText.text = "You actually killed it?! Sigh...I guess I lost\n" +
            "You may now proceed to the arena";

        }
    }
    void OnTriggerExit(Collider other)
    {

        tutorailPopups.SetActive(false);


    }

}
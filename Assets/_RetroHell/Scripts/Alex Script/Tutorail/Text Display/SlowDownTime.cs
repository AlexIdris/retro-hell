using TMPro;
using UnityEngine;

public class SlowDownTime : MonoBehaviour
{
    [SerializeField] TMP_Text tutorText;
    [SerializeField] GameObject frame;
    [SerializeField] GameObject tutorailPopups;
    [SerializeField] AudioSource robotAudioSource;

    private void Start()
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
            tutorText.text = "Pick up the time watch, it slows down time.\n" +
                "<Press Shift to slow down time for 3 seconds.>";
        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);

            tutorText.text = "Pick up the time watch, it slows down time.\n" +
              "<Press Shift to slow down time for 3 seconds.>";
        }
    }

    void OnTriggerExit(Collider other)
    {

        tutorailPopups.SetActive(false);

    }

}
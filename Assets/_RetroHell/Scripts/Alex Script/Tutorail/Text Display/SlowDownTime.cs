using TMPro;
using UnityEngine;

public class SlowDownTime : MonoBehaviour
{
    [SerializeField] TMP_Text tutorText;
    [SerializeField] GameObject frame;
    [SerializeField] GameObject tutorailPopups;
    [SerializeField] AudioSource robotAudioSource;



    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);
            robotAudioSource.Play();
            tutorText.text = "Now, to complete your Arsenal, pick up the Orxic watch, and let's see what you have learned.\n" +
                "Observe the screen if there are any complications";
        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);

            tutorText.text = "Now, to complete your Arsenal, pick up the Orxic watch, and let's see what you have learned.\n" +
                "Observe the screen if there are any complications";
        }
    }

    void OnTriggerExit(Collider other)
    {

        tutorailPopups.SetActive(false);

    }

}
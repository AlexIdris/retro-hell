using TMPro;
using UnityEngine;

public class Machinegun : MonoBehaviour
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
            tutorText.text = "Automatic Rifle Time!!\n" +
                "<Each mag holds 30 bullets of rapid-fire!!!>";

        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);

            tutorText.text = "Automatic Rifle Time!!\n" +
                "<Each mag holds 30 bullets of rapid-fire!!!>";

        }
    }
    void OnTriggerExit(Collider other)
    {

        tutorailPopups.SetActive(false);

    }

}
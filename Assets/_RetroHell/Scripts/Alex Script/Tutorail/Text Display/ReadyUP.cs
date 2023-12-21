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
            tutorText.text = "Your training is over. Heal up and move towards the portal.\n" +
                "<The portal teleports you to new scenes.>";

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
            tutorText.text = "Your training is over. Heal up and move towards the portal.\n" +
                "<The portal teleports you to new scenes.>";

        }
    }
    void OnTriggerExit(Collider other)
    {

        tutorailPopups.SetActive(false);


    }

}
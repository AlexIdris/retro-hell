using TMPro;
using UnityEngine;

public class Shooting : MonoBehaviour
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
            tutorText.text = "Let test what you have learned so far,\n" +
                "this is a breakable wall, break it.\n" +
                "<Left-Click to fire your Gun.>";

        }

    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);
            tutorText.text = "Let test what you have learned so far,\n" +
               "this is a breakable wall, break it.\n" +
               "<Left-Click to fire your Gun.>";


        }
    }
    void OnTriggerExit(Collider other)
    {

        tutorailPopups.SetActive(false);

    }

}
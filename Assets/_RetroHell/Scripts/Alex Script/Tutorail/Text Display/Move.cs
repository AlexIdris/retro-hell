using TMPro;
using UnityEngine;

public class Move : MonoBehaviour
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

        if (other.tag is "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);
            robotAudioSource.Play();
            tutorText.text = "Hi, I'm your old relaible Orxic \n" +
              " & today I will be your guide.\n" +
          "<Use WASD for Movement>";



        }

    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag is "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);
            tutorText.text = "Hi, I'm your old relaible Orxic \n" +
                " & today I will be your guide.\n" +
            "<Use WASD for Movement>";
        }
    }
    void OnTriggerExit(Collider other)
    {

        tutorailPopups.SetActive(false);

    }

}
using TMPro;
using UnityEngine;

public class Avoid : MonoBehaviour
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
        if (other.tag is "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);
            robotAudioSource.Play();
            tutorText.text = " Those balls hurt, so try not to get hit. \n" +
      "<Avoid getting hit by the bullets, all red bullets can be destroyed.>";


        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag is "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);

            tutorText.text = " Those balls hurt, so try not to get hit. \n" +
     "<Avoid getting hit by the bullets, all red bullets can be destroyed.>";


        }
    }
    void OnTriggerExit(Collider other)
    {

        tutorailPopups.SetActive(false);

    }

}
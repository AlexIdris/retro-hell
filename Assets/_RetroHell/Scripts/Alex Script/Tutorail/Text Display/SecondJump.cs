using TMPro;
using UnityEngine;

public class SecondJump : MonoBehaviour
{
    [SerializeField] TMP_Text tutorText;
    [SerializeField] GameObject frame;
    [SerializeField] GameObject tutorailPopups;
    [SerializeField] AudioSource robotAudioSource;

    private void Start()
    {
        tutorailPopups.SetActive(false);
    }
    async private void OnTriggerEnter(Collider other)
    {

        tutorailPopups.SetActive(true);
        frame.SetActive(true);
        tutorText.gameObject.SetActive(true);
        robotAudioSource.Play();

        tutorText.text = "Watch your step";




    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);
            tutorText.text = "Watch your step";




        }
    }
    void OnTriggerExit(Collider other)
    {

        tutorailPopups.SetActive(false);

    }

}
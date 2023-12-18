using TMPro;
using UnityEngine;

public class ReadyUP : MonoBehaviour
{
    [SerializeField] TMP_Text TutorText;
    [SerializeField] GameObject Frame;
    [SerializeField] GameObject TutorailPopups;

    [SerializeField] AudioSource RobotAudioSource;
    private void Awake()
    {
        TutorailPopups.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            Frame.SetActive(true);

            TutorText.gameObject.SetActive(true);
            RobotAudioSource.Play();
            TutorText.text = "Your Training is over, Heal up and go towards the light\n" +
                "<White light teleport you to new scenes>";

        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            Frame.SetActive(true);

            TutorText.gameObject.SetActive(true);

            TutorText.text = "Your Training is over, Heal up and go towards the light\n" +
                "<White light teleport you to new scenes>";

        }
    }
    void OnTriggerExit(Collider other)
    {

        TutorailPopups.SetActive(false);


    }

}
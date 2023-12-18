using TMPro;
using UnityEngine;

public class Machinegun : MonoBehaviour
{
    [SerializeField] TMP_Text TutorText;
    [SerializeField] GameObject Frame;
    [SerializeField] GameObject TutorailPopups;
    [SerializeField] AudioSource RobotAudioSource;
    private void Start()
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

            TutorText.text = "Automatic Rifle Time!!\n" +
                "<Each mag holds 30 bullets of rapid-fire!!!>";
            RobotAudioSource.Play();
        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            Frame.SetActive(true);
            TutorText.gameObject.SetActive(true);
            TutorText.text = "Automatic Rifle Time!!\n" +
                "<Each mag holds 30 bullets of rapid-fire!!!>";
            RobotAudioSource.Play();
        }
    }
    void OnTriggerExit(Collider other)
    {

        TutorailPopups.SetActive(false);

    }

}
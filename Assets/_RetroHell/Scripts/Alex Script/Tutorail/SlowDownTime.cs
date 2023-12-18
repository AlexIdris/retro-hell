using TMPro;
using UnityEngine;

public class SlowDownTime : MonoBehaviour
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
            RobotAudioSource.Play();
            TutorText.text = "Pick up the time watch. as you can guess from it name, it slows down time\n" +
                "<Press Shift to slow down time for 3 seconds>";
        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            Frame.SetActive(true);
            TutorText.gameObject.SetActive(true);

            TutorText.text = "Pick up the time watch. as you can guess from it name, it slows down time\n" +
                "<Press Shift to slow down time for 3 seconds>";
        }
    }
    void OnTriggerExit(Collider other)
    {

        TutorailPopups.SetActive(false);

    }

}
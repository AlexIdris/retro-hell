using TMPro;
using UnityEngine;

public class Move : MonoBehaviour
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
            TutorText.text = "Hi, am Orxic, your old relaible\n" +
               " & today i will be your guide\n" +
           "<Press WASD for Movement>";



        }

    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            Frame.SetActive(true);
            TutorText.gameObject.SetActive(true);

            TutorText.text = "Hi, am Orxic, your old relaible\n" +
                " & today i will be your guide\n" +
            "<Press WASD for Movement>";
        }
    }
    void OnTriggerExit(Collider other)
    {

        TutorailPopups.SetActive(false);

    }

}
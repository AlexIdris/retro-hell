using TMPro;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    [SerializeField] TMP_Text TutorText;
    [SerializeField] GameObject Frame;
    [SerializeField] GameObject TutorailPopups;
    [SerializeField] GameObject crouchBullet;
    [SerializeField] AudioSource RobotAudioSource;
    private void Awake()
    {
        TutorailPopups.SetActive(false);
        crouchBullet.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            Frame.SetActive(true);
            crouchBullet.SetActive(true);
            TutorText.gameObject.SetActive(true);
            RobotAudioSource.Play();
            TutorText.text = "Now we learn Crouching \n" +
                "And you know what they say, behind every small space is a trap.\n" +
                "<Press Control to Crouch.>";

        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            Frame.SetActive(true);
            crouchBullet.SetActive(true);
            TutorText.gameObject.SetActive(true);

            TutorText.text = "Now we learn Crouching \n" +
                "And you know what they say, behind every small space is a trap.\n" +
                "<Press Control to Crouch.>";

        }
    }
    void OnTriggerExit(Collider other)
    {

        TutorailPopups.SetActive(false);


    }

}
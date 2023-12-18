using TMPro;
using UnityEngine;

public class Jump : MonoBehaviour
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
        TutorailPopups.SetActive(true);
        Frame.SetActive(true);
        TutorText.gameObject.SetActive(true);
        RobotAudioSource.Play();
        TutorText.text = "Oh good you can move, now Jump over the bumps\n" +
            "<Press Space to Jump.>";



    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            Frame.SetActive(true);
            TutorText.gameObject.SetActive(true);
            TutorText.text = "Oh good you can move, now Jump over the bumps\n" +
                "<Press Space to Jump.>";

        }
    }
    void OnTriggerExit(Collider other)
    {

        TutorailPopups.SetActive(false);

    }

}
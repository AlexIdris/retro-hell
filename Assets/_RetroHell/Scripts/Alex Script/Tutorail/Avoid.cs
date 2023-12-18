using TMPro;
using UnityEngine;

public class Avoid : MonoBehaviour
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
            TutorText.text = " Those Balls hurts so try not to get hit \n" +
     "<Avoid Getting hit by the Turret Bullets>";


        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            Frame.SetActive(true);
            TutorText.gameObject.SetActive(true);

            TutorText.text = " Those Balls hurts so try not to get hit \n" +
     "<Avoid Getting hit by the Turret Bullets>";


        }
    }
    void OnTriggerExit(Collider other)
    {

        TutorailPopups.SetActive(false);

    }

}
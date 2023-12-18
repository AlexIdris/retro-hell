using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] TMP_Text TutorText;
    [SerializeField] GameObject Frame;
    [SerializeField] GameObject TutorailPopups;
    [SerializeField] AudioSource RobotAudioSource;
    public Player_Control playerControl;
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
            if (playerControl.playercurrentHealth <= 90)
            {
                TutorText.text = "Awn poor baby you took damage,now heal your self, Pick up the Health Essence.\n" +
               "<It recovers 50 Health Points.>";
            }
            else if (playerControl.playercurrentHealth >= 90)
            {
                TutorText.text = "Okey tough guy, i guess you wont be needing the Health Essence, but you should know what it does.\n" +
              "<It recovers 50 Health Points.>";
            }



        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            Frame.SetActive(true);
            TutorText.gameObject.SetActive(true);
            if (playerControl.playercurrentHealth <= 90)
            {
                TutorText.text = "Awn poor baby you took damage,now heal your self, Pick up the Health Essence.\n" +
               "<It recovers 50 Health Points.>";
            }
            else if (playerControl.playercurrentHealth >= 90)
            {
                TutorText.text = "Okey tough guy, i guess you wont be needing the Health Essence, but you should know what it does.\n" +
              "<It recovers 50 Health Points.>";
            }

        }
    }
    void OnTriggerExit(Collider other)
    {

        TutorailPopups.SetActive(false);

    }

}
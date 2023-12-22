using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] TMP_Text tutorText;
    [SerializeField] GameObject frame;
    [SerializeField] GameObject tutorailPopups;
    [SerializeField] AudioSource robotAudioSource;
    public Player_Control playerControl;
    private void Start()
    {
        tutorailPopups.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);
            robotAudioSource.Play();
            if (playerControl.playercurrentHealth <= 90)
            {
                tutorText.text = "Awn poor baby you took damage,now heal your self, Pick up the Health Essence.\n" +
               "<It recovers 50 Health Points.>";
            }
            else if (playerControl.playercurrentHealth >= 90)
            {
                tutorText.text = "Okey, tough guy, i guess you wont be needing the Health Essence, but you should know what it does.\n" +
              "<It recovers 50 Health Points.>";
            }



        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);

            if (playerControl.playercurrentHealth <= 90)
            {
                tutorText.text = "Awn poor baby you took damage,now heal your self, Pick up the Health Essence.\n" +
               "<It recovers 50 Health Points.>";
            }
            else if (playerControl.playercurrentHealth >= 90)
            {
                tutorText.text = "Okey, tough guy, i guess you wont be needing the Health Essence, but you should know what it does.\n" +
              "<It recovers 50 Health Points.>";
            }

        }
    }
    void OnTriggerExit(Collider other)
    {

        tutorailPopups.SetActive(false);

    }

}
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] TMP_Text tutorText;
    [SerializeField] GameObject frame;
    [SerializeField] GameObject tutorailPopups;
    [SerializeField] AudioSource robotAudioSource;
    [SerializeField] GameObject invincibleWalls;
    [SerializeField] GameObject robot;
    public Player_Control playerControl;
    private void Start()
    {
        tutorailPopups.SetActive(false);
        robot.SetActive(false);
        invincibleWalls.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);
            robotAudioSource.Play();

            tutorText.text = "Behind You!";



        }
    }
    async void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);

            tutorText.text = "Behind You!";
            await Task.Delay(4000);
            invincibleWalls.SetActive(false);
            robot.SetActive(true);

        }
    }
    void OnTriggerExit(Collider other)
    {

        tutorailPopups.SetActive(false);

    }

}
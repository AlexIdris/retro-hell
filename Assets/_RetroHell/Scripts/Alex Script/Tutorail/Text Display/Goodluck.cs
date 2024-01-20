using TMPro;
using UnityEngine;

public class Goodluck : MonoBehaviour
{
    [SerializeField] TMP_Text tutorText;
    [SerializeField] GameObject frame;
    [SerializeField] GameObject tutorailPopups;
    [SerializeField] GameObject bossEnemyHealth;
    [SerializeField] GameObject tutorailMinibossHealth;
    [SerializeField] AudioSource robotAudioSource;
    private void Awake()
    {
        tutorailPopups.SetActive(false);
        bossEnemyHealth.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag is "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);
            bossEnemyHealth.SetActive(true);
            tutorailMinibossHealth.SetActive(false);
            robotAudioSource.Play();
            tutorText.text = "Yawn. Am still Sleepy\n" +
               " Hmm...I feel like I am forgetting something.. \n" +
           "Oh Yeah! The longer it takes you to defeat an enemy, the stronger it becomes\n" +
            "Soo... Goodluck and keep me entertained";

        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag is "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);
            bossEnemyHealth.SetActive(true);
            tutorailMinibossHealth.SetActive(false);

            tutorText.text = "Yawn. Am still Sleepy\n" +
               " Hmm...I feel like I am forgetting something.. \n" +
           "Oh Yeah! The longer it takes you to defeat an enemy, the stronger it becomes\n" +
             "Soo... Good luck and keep me entertained";

        }
    }
    void OnTriggerExit(Collider other)
    {
        tutorailMinibossHealth.SetActive(false);
        tutorailPopups.SetActive(false);

    }

}
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
            tutorText.text = "Yikes! That looks scary... Wait, I just remembered\n" +
" this is a single-player game so technically I'm good, Good Luck!\n" +
 "<The longer you fight, the stronger the enemy becomes...\n" +
 "Also, blue and black bullets can not be destroyed :) >";

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

            tutorText.text = "Yikes! That looks scary... Wait, I just remembered\n" +
            " this is a single-player game so technically I'm good, Good Luck!\n" +
             "<The longer you fight, the stronger the enemy becomes...\n" +
             "Also, blue and black bullets can not be destroyed :) >";

        }
    }
    void OnTriggerExit(Collider other)
    {
        tutorailMinibossHealth.SetActive(false);
        tutorailPopups.SetActive(false);

    }

}
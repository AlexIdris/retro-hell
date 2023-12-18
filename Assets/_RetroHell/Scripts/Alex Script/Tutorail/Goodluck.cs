using TMPro;
using UnityEngine;

public class Goodluck : MonoBehaviour
{
    [SerializeField] TMP_Text TutorText;
    [SerializeField] GameObject Frame;
    [SerializeField] GameObject TutorailPopups;
    [SerializeField] GameObject BossEnemyHealth;
    [SerializeField] GameObject TutorailMinibossHealth;
    [SerializeField] AudioSource RobotAudioSource;
    private void Awake()
    {
        TutorailPopups.SetActive(false);
        BossEnemyHealth.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            Frame.SetActive(true);
            TutorText.gameObject.SetActive(true);
            BossEnemyHealth.SetActive(true);
            TutorailMinibossHealth.SetActive(false);
            RobotAudioSource.Play();
            TutorText.text = "Yikes! That looks scary...\n" +
                "I mean, I just remembered, this is a single player game, So Goodluck :)\n" +
                 "<You should know the longer you fight an enemy the stronger it becomes>";

        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            Frame.SetActive(true);
            TutorText.gameObject.SetActive(true);
            BossEnemyHealth.SetActive(true);
            TutorailMinibossHealth.SetActive(false);
            TutorText.text = "Yikes! That looks scary...\n" +
                "I mean, I just remembered, this is a single player game, So Goodluck :)\n" +
                 "<You should know the longer you fight an enemy the stronger it becomes>";

        }
    }
    void OnTriggerExit(Collider other)
    {
        TutorailMinibossHealth.SetActive(false);
        TutorailPopups.SetActive(false);

    }

}
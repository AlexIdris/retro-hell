using TMPro;
using UnityEngine;

public class Miniboss : MonoBehaviour
{
    [SerializeField] TMP_Text TutorText;
    [SerializeField] GameObject Frame;
    [SerializeField] GameObject TutorailPopups;
    [SerializeField] GameObject TutorailMinibossHealth;
    [SerializeField] GameObject MiniminiBoss;
    [SerializeField] GameObject BossEnemyHealth;
    [SerializeField] AudioSource RobotAudioSource;
    private void Start()
    {
        TutorailPopups.SetActive(false);
        TutorailMinibossHealth.SetActive(false);
        MiniminiBoss.SetActive(false);
        BossEnemyHealth.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            TutorailMinibossHealth.SetActive(true);
            Frame.SetActive(true);
            TutorText.gameObject.SetActive(true);
            MiniminiBoss.SetActive(true);
            BossEnemyHealth.SetActive(false);
            RobotAudioSource.Play();
            TutorText.text = "Time to play with our new toys.\n" +
                "<Right-Click to fire the Machine Gun>\n" +
                "<Your Bullet destroys other enemy's bullets>";



        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            Frame.SetActive(true);
            TutorText.gameObject.SetActive(true);
            TutorailMinibossHealth.SetActive(true);
            BossEnemyHealth.SetActive(false);
            TutorText.text = "Time to play with our new toys.\n" +
                 "<Right-Click to fire the Machine Gun>\n" +
                 "<Your Bullet destroys other enemy's bullets>";



        }
    }
    void OnTriggerExit(Collider other)
    {
        TutorailMinibossHealth.SetActive(false);
        TutorailPopups.SetActive(false);

    }
}
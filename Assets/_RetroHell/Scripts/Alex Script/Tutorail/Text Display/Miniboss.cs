using TMPro;
using UnityEngine;

public class Miniboss : MonoBehaviour
{
    [SerializeField] TMP_Text tutorText;
    [SerializeField] GameObject frame;
    [SerializeField] GameObject tutorailPopups;
    [SerializeField] AudioSource robotAudioSource;
    [SerializeField] GameObject tutorailMinibossHealth;
    [SerializeField] GameObject miniMiniBoss;


    private void Start()
    {

        tutorailMinibossHealth.SetActive(false);
        miniMiniBoss.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag is "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);
            robotAudioSource.Play();
            tutorText.gameObject.SetActive(true);
            miniMiniBoss.SetActive(true);
            tutorailMinibossHealth.SetActive(true);
            tutorText.text = "Time to play with our new toys.\n" +
                 "<Right-Click to fire the Machine Gun>\n" +
                 "<Your Bullet destroys other enemy's bullets>";



        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag is "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);
            tutorText.gameObject.SetActive(true);
            miniMiniBoss.SetActive(true);
            tutorailMinibossHealth.SetActive(true);
            tutorText.text = "Time to play with our new toys.\n" +
                 "<Right-Click to fire the Machine Gun>\n" +
                 "<Your Bullet destroys other enemy's bullets>";




        }
    }
    void OnTriggerExit(Collider other)
    {
        tutorailPopups.SetActive(true);


    }
}
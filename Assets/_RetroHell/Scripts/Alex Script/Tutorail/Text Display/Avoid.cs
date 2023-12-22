using TMPro;
using UnityEngine;

public class Avoid : MonoBehaviour
{
    [SerializeField] TMP_Text tutorText;
    [SerializeField] GameObject frame;
    [SerializeField] GameObject tutorailPopups;
    [SerializeField] AudioSource robotAudioSource;

    private void Awake()
    {
        tutorailPopups.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag is "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);
            robotAudioSource.Play();
            tutorText.text = " Those Balls hurts, so try not to get hit \n" +
      "<Avoid Getting hit by the Turret Bullets, All Red Bullet can be Destroyed>";


        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag is "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);

            tutorText.text = " Those Balls hurts, so try not to get hit \n" +
     "<Avoid Getting hit by the Turret Bullets, All Red Bullet can be Destroyed>";


        }
    }
    void OnTriggerExit(Collider other)
    {

        tutorailPopups.SetActive(false);

    }

}
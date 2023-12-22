using TMPro;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    [SerializeField] TMP_Text tutorText;
    [SerializeField] GameObject frame;
    [SerializeField] GameObject tutorailPopups;
    [SerializeField] GameObject crouchBullet;
    [SerializeField] AudioSource robotAudioSource;
    private void Awake()
    {
        tutorailPopups.SetActive(false);
        crouchBullet.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            crouchBullet.SetActive(true);
            tutorText.gameObject.SetActive(true);
            robotAudioSource.Play();
            tutorText.text = "Now we learn Jumping & Crouching with Deadly Bullets\n" +
             "Blue Balls can only Jumped Over, " +
             "While Red Balls Need to be crouched passed\n" +
             "<Press Control to Crouch.>";
        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            crouchBullet.SetActive(true);
            tutorText.gameObject.SetActive(true);

            tutorText.text = "Now we learn Jumping & Crouching with Deadly Bullets\n" +
                "Blue Balls can only Jumped Over, " +
                "While Red Balls Need to be crouched passed\n" +
                "<Press Control to Crouch.>";

        }
    }
    void OnTriggerExit(Collider other)
    {

        tutorailPopups.SetActive(false);


    }

}
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
            tutorText.text = "Now we'll learn jumping & crouching with deadlier balls.\n" +
             "Blue bullets can only jumped over, " +
             "while red bullets need to be crouched to pass.\n" +
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

            tutorText.text = "Now we'll learn jumping & crouching with deadlier balls.\n" +
                "Blue bullets can only jumped over, " +
                "while red bullets need to be crouched to pass.\n" +
                "<Press Control to Crouch.>";

        }
    }
    void OnTriggerExit(Collider other)
    {

        tutorailPopups.SetActive(false);


    }

}
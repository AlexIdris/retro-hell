using TMPro;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] TMP_Text tutorText;
    [SerializeField] GameObject frame;
    [SerializeField] GameObject tutorailPopups;
    [SerializeField] AudioSource robotAudioSource;
    private void Start()
    {
        tutorailPopups.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        tutorailPopups.SetActive(true);
        frame.SetActive(true);
        tutorText.gameObject.SetActive(true);
        robotAudioSource.Play();
        tutorText.text = "Oh, good! You can move. Now Jump over the bumps.\n" +
            "<Press Space to Jump.>";



    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);

            tutorText.text = "Oh, good! You can move. Now Jump over the bumps.\n" +
                "<Press Space to Jump.>";

        }
    }
    void OnTriggerExit(Collider other)
    {

        tutorailPopups.SetActive(false);

    }

}
using TMPro;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    [SerializeField] TMP_Text TutorText;
    [SerializeField] GameObject Frame;
    [SerializeField] GameObject TutorailPopups;
    [SerializeField] GameObject crouchBullet;
    private void Awake()
    {
        TutorailPopups.SetActive(false);
        crouchBullet.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            Frame.SetActive(true);
            crouchBullet.SetActive(true);
            TutorText.gameObject.SetActive(true);

            TutorText.text = "<Press Control to Crouch>\n" +
                "Avoid Getting Hit by the Turret";

        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            Frame.SetActive(true);
            crouchBullet.SetActive(true);
            TutorText.gameObject.SetActive(true);
            TutorText.text = "<Press Control to Crouch>\n" +
           "Avoid Getting Hit by the Turret";

        }
    }
    void OnTriggerExit(Collider other)
    {

        TutorailPopups.SetActive(false);
        crouchBullet.SetActive(false);

    }

}
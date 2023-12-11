using TMPro;
using UnityEngine;

public class Avoid : MonoBehaviour
{
    [SerializeField] TMP_Text TutorText;
    [SerializeField] GameObject Frame;
    [SerializeField] GameObject TutorailPopups;

    private void Awake()
    {
        TutorailPopups.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            Frame.SetActive(true);
            TutorText.gameObject.SetActive(true);

            TutorText.text = "<Avoid Getting Hit by the Turret>\n" +
                " This Kills, try not to die";

        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            Frame.SetActive(true);
            TutorText.gameObject.SetActive(true);
            TutorText.text = "<Press Control to Crouch>\n" +
           "Avoid Getting Hit by the Turret";

        }
    }
    void OnTriggerExit(Collider other)
    {

        TutorailPopups.SetActive(false);

    }

}
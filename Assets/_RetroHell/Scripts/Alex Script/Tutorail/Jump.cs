using TMPro;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] TMP_Text TutorText;
    [SerializeField] GameObject Frame;
    [SerializeField] GameObject TutorailPopups;
    private void Start()
    {
        TutorailPopups.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        TutorailPopups.SetActive(true);
        Frame.SetActive(true);
        TutorText.gameObject.SetActive(true);

        TutorText.text = "<Press Space to Jump.>\n" +
            "Jump over the lasers.";



    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            Frame.SetActive(true);
            TutorText.gameObject.SetActive(true);
            TutorText.text = "<Press Space to Jump.>\n" +
                "Jump over the lasers.";

        }
    }
    void OnTriggerExit(Collider other)
    {

        TutorailPopups.SetActive(false);

    }

}
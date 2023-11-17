using TMPro;
using UnityEngine;

public class Basic_Tutorail : MonoBehaviour
{
    [SerializeField] TMP_Text TutorText;
    [SerializeField] TMP_Text IntructionText;
    [SerializeField] GameObject Frame;
    [SerializeField] GameObject Next;
    [SerializeField] GameObject Previous;
    private void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            Frame.SetActive(true);
            TutorText.gameObject.SetActive(true);

            TutorText.text = "WASD for Movement\n" +
                "Left Click Mouse for Shooting\n" +
                "E to Slowdown Time\n";

            IntructionText.text = "Press 2 for Next";
            Next.SetActive(true);
            Previous.SetActive(false);
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {

            Frame.SetActive(true);
            TutorText.gameObject.SetActive(true);

            TutorText.text = "WASD for Movement\n" +
                "Left Click Mouse for Shooting\n" +
                "E to Slowdown Time\n";

            IntructionText.text = "Press 2 for Next";
            Next.SetActive(true);
            Previous.SetActive(false);

            if (Input.GetKey(KeyCode.Alpha2))
            {
                TutorText.text = "Blue Box Indicate Machineguns\n " +
                "Right Click Mouse to Active Machinegun\n" +
                 "Green Box = +50 Health\n" +
                 "Destroy the Enemy\n" +
                 "Try not to Die!";
                IntructionText.text = "Press 1 to go Back ";
                Next.SetActive(false);
                Previous.SetActive(true);
            }
            if (Input.GetKey(KeyCode.Alpha1))
            {
                TutorText.text = "WSAD for Movement\n" +
               "Left Click Mouse for Shooting\n" +
               "E to Slowdown Time\n";
                IntructionText.text = "Press 2 for Next";
                Next.SetActive(true);
                Previous.SetActive(false);
            }

        }
    }
    void OnTriggerExit(Collider other)
    {

        Frame.SetActive(false);
        TutorText.gameObject.SetActive(false);
        Next.SetActive(false);
        Previous.SetActive(false);

    }

}
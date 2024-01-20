using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class CrouchTease : MonoBehaviour
{
    [SerializeField] TMP_Text tutorText;
    [SerializeField] GameObject frame;
    [SerializeField] GameObject tutorailPopups;
    [SerializeField] bool bend = true;
    [SerializeField] AudioSource robotAudioSource;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            Bendtext();
            tutorText.gameObject.SetActive(true);
            robotAudioSource.Play();




        }
    }


    async void Bendtext()
    {
        tutorText.text =
           "WAIT!!";
        await Task.Delay(2000);
        tutorText.text =
        "So you were paying attention, good for you";
        await Task.Delay(2500);
        tutorText.text =
       "That's all, you can go now";
        await Task.Delay(3000);
        tutorailPopups.SetActive(false);
        bend = true;
    }
}

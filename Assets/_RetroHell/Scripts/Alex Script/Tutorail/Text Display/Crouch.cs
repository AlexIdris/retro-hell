using System.Threading.Tasks;
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
            tutorText.text = "Well that was Fun you wanna do it again\n" +
             "Or are you going to be boring and crouch.";


        }


    }
    async private void OnTriggerStay(Collider other)
    {
        await Task.Delay(3000);
        top();
    }




    async void top()
    {
        if (Input.anyKey && !Input.GetKey(KeyCode.LeftControl) || Input.anyKeyDown && !Input.GetKey(KeyCode.LeftControl))
        {
            tutorText.text = "crouch with Left-Control Noob";
            await Task.Delay(2000);

            tutorailPopups.SetActive(false);
        }
    }
}

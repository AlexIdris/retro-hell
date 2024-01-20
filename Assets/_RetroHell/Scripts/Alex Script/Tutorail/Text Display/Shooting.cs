using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] TMP_Text tutorText;
    [SerializeField] TMP_Text achievementText;
    [SerializeField] GameObject achievementPopup;
    [SerializeField] GameObject tutorailPopups;
    [SerializeField] GameObject devineTutorailPopups;
    [SerializeField] GameObject frame;
    [SerializeField] AudioSource robotAudioSource;
    [SerializeField] GameObject gun;
    [SerializeField] GameObject gunDesplay;
    [SerializeField] GameObject gunFrame;
    [SerializeField] GameObject target;
    [SerializeField] bool achievementgun = true;
    private void Start()
    {
        tutorailPopups.SetActive(false);
        gunFrame.SetActive(false);
        gun.SetActive(false);
        gunDesplay.SetActive(false);
        achievementPopup.SetActive(false);
        target.SetActive(false);
    }

    async private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            devineTutorailPopups.SetActive(false);
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);
            robotAudioSource.Play();
            tutorText.text = "Hi am Trevor the big toe. I am told know how to jump and crouch\n" +
                "In that case, let's play a minigame. Take this Neon Blaster and break the glass to get to the other side.\n";
            await Task.Delay(5000);
            achievementPopup.SetActive(true);
            achievementgun = true;
            Achive();
        }

    }
    async void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            devineTutorailPopups.SetActive(false);
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            tutorText.gameObject.SetActive(true);
            tutorText.text = tutorText.text = "Hi am Trevor the big toe. I am told know how to jump and crouch\n" +
                "In that case, let's play a minigame. Take this Neon Blaster and break the glass to get to the other side.\n";
            await Task.Delay(5000);
            target.SetActive(true);
            gunFrame.SetActive(true);
            gun.SetActive(true);
            gunDesplay.SetActive(true);





        }
    }
    void OnTriggerExit(Collider other)
    {

        tutorailPopups.SetActive(false);



    }
    async void Achive()
    {
        achievementText.text = "*Neon Blaster aquired*\n" +
                "Left-Click to fire.";
        await Task.Delay(3000);
        achievementPopup.SetActive(false);
        achievementgun = false;
    }
}
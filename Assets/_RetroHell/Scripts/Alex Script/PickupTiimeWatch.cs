using System.Threading.Tasks;
using TMPro;
using UnityEngine;
public class PickupTiimeWatch : MonoBehaviour
{
    [SerializeField] GameObject pocketWatch;
    [SerializeField] GameObject stopWatch;
    [SerializeField] GameObject iw_PocketWatch;
    [SerializeField] AudioSource audioSource;
    [SerializeField] TMP_Text achievementText;
    [SerializeField] GameObject achievementPopup;
    [SerializeField] GameObject tutorailMinibossHealth;
    [SerializeField] GameObject miniMiniBoss;
    private void Start()
    {
        miniMiniBoss.SetActive(false);
        iw_PocketWatch.SetActive(true);
        stopWatch.SetActive(false);
        pocketWatch.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            pocketWatch.SetActive(true);
            stopWatch.SetActive(true);
            iw_PocketWatch.SetActive(false);
            audioSource.Play();
            Destroy(gameObject);
            miniMiniBoss.SetActive(true);
            tutorailMinibossHealth.SetActive(true);
        }
    }

    private async void OnDestroy()
    {

        achievementText.text = "*Orxic aquired*\n" +
            "Left-Shift to slow down time for 3 seconds.";
        await Task.Delay(3000);
        achievementPopup.SetActive(false);
    }

}

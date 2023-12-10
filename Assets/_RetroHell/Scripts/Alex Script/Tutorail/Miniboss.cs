using TMPro;
using UnityEngine;

public class Miniboss : MonoBehaviour
{
    [SerializeField] TMP_Text TutorText;
    [SerializeField] GameObject Frame;
    [SerializeField] GameObject TutorailPopups;
    [SerializeField] GameObject TutorailMinibossHealth;
    [SerializeField] GameObject MiniminiBoss;
    [SerializeField] GameObject BossEnemyHealth;
    private void Start()
    {
        TutorailPopups.SetActive(false);
        TutorailMinibossHealth.SetActive(false);
        MiniminiBoss.SetActive(false);
        BossEnemyHealth.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            Frame.SetActive(true);
            TutorText.gameObject.SetActive(true);
            MiniminiBoss.SetActive(true);
            BossEnemyHealth.SetActive(false);
            TutorText.text = "<Right-Click to fire the Machine Gun.>\n" +
                "Use your new weapon to defeat the enemy.";
        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            Frame.SetActive(true);
            TutorText.gameObject.SetActive(true);
            TutorailMinibossHealth.SetActive(true);
            MiniminiBoss.SetActive(true);
            BossEnemyHealth.SetActive(false);
            TutorText.text = "<Right-Click to fire the Machine Gun.>\n" +
                "Use your new weapon to defeat the enemy.";


        }
    }
    void OnTriggerExit(Collider other)
    {
        TutorailMinibossHealth.SetActive(false);
        TutorailPopups.SetActive(false);

    }

}
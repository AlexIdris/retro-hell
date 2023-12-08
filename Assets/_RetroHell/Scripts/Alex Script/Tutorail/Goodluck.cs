using TMPro;
using UnityEngine;

public class Goodluck : MonoBehaviour
{
    [SerializeField] TMP_Text TutorText;
    [SerializeField] GameObject Frame;
    [SerializeField] GameObject TutorailPopups;
    [SerializeField] GameObject BossEnemyHealth;
    private void Awake()
    {
        TutorailPopups.SetActive(false);
        BossEnemyHealth.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            Frame.SetActive(true);
            TutorText.gameObject.SetActive(true);
            BossEnemyHealth.SetActive(true);
            TutorText.text = "<Descend downward and face your enemy.>\n" +
                "Good Luck, Soldier.";
        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorailPopups.SetActive(true);
            Frame.SetActive(true);
            TutorText.gameObject.SetActive(true);
            BossEnemyHealth.SetActive(true);
            TutorText.text = "<Descend downward and face your enemy.>\n" +
                "Good Luck, Soldier.";

        }
    }
    void OnTriggerExit(Collider other)
    {

        TutorailPopups.SetActive(false);

    }

}
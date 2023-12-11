using TMPro;
using UnityEngine;

public class Goodluck : MonoBehaviour
{
    [SerializeField] TMP_Text TutorText;
    [SerializeField] GameObject Frame;
    [SerializeField] GameObject TutorailPopups;
    [SerializeField] GameObject BossEnemyHealth;
    [SerializeField] GameObject TutorailMinibossHealth;
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
            TutorailMinibossHealth.SetActive(false);
            TutorText.text = "Yikes. Well I am sure you do not want a guardian angel in your ear, so Goodluck.\n" +
     "<Descend downward and face your enemy.>";
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
            TutorailMinibossHealth.SetActive(false);
            TutorText.text = "Yikes. Well I am sure you do not want a guardian angel in your ear, so Goodluck.\n" +
                 "<Descend downward and face your enemy.>";

        }
    }
    void OnTriggerExit(Collider other)
    {
        TutorailMinibossHealth.SetActive(false);
        TutorailPopups.SetActive(false);

    }

}
using UnityEngine;

public class IBotTalking : MonoBehaviour
{
    [SerializeField] GameObject botTalking;

    void Start()
    {
        botTalking.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        botTalking.SetActive(true);
    }
    private void OnTriggerStay(Collider other)
    {
        botTalking.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        botTalking.SetActive(false);
    }
}

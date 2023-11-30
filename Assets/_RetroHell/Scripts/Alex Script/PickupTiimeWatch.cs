using UnityEngine;

public class PickupTiimeWatch : MonoBehaviour
{
    [SerializeField] GameObject PocketWatch;
    [SerializeField] GameObject StopWatch;

    private void Start()
    {
        PocketWatch.SetActive(false);
        StopWatch.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        PocketWatch?.SetActive(true);
        StopWatch?.SetActive(true);
        Destroy(gameObject);
    }
    private void OnTriggerStay(Collider other)
    {
        PocketWatch?.SetActive(true);
        StopWatch?.SetActive(true);
        Destroy(gameObject);
    }
    private void OnTriggerExit(Collider other)
    {

    }
}

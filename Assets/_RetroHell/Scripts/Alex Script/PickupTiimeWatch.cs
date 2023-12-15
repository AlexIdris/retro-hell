using UnityEngine;

public class PickupTiimeWatch : MonoBehaviour
{
    [SerializeField] GameObject PocketWatch;
    [SerializeField] GameObject StopWatch;
    [SerializeField] GameObject IW_PocketWatch;
    [SerializeField] AudioSource audioSource;
    private void Start()
    {
        PocketWatch.SetActive(false);
        StopWatch.SetActive(false);
        IW_PocketWatch.SetActive(true);

    }
    private void OnTriggerEnter(Collider other)
    {
        PocketWatch.SetActive(true);
        StopWatch.SetActive(true);
        IW_PocketWatch.SetActive(false);

        Destroy(gameObject);
    }
    private void OnTriggerStay(Collider other)
    {
        PocketWatch.SetActive(true);
        StopWatch.SetActive(true);
        IW_PocketWatch.SetActive(false);
        audioSource.Play();
        Destroy(gameObject);
    }


}

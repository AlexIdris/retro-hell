using UnityEngine;

public class PickupTiimeWatch : MonoBehaviour
{
    [SerializeField] GameObject pocketWatch;
    [SerializeField] GameObject stopWatch;
    [SerializeField] GameObject iw_PocketWatch;
    [SerializeField] AudioSource audioSource;
    private void Start()
    {

        iw_PocketWatch.SetActive(true);

    }
    private void OnTriggerEnter(Collider other)
    {
        pocketWatch.SetActive(true);
        stopWatch.SetActive(true);
        iw_PocketWatch.SetActive(false);

        Destroy(gameObject);
    }
    private void OnTriggerStay(Collider other)
    {
        pocketWatch.SetActive(true);
        stopWatch.SetActive(true);
        iw_PocketWatch.SetActive(false);
        audioSource.Play();
        Destroy(gameObject);
    }


}

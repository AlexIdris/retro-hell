using UnityEngine;

public class Quit_Popup : MonoBehaviour
{
    [SerializeField] GameObject Exitpopup;

    private void Awake()
    {
        Exitpopup.SetActive(false);
    }
    public void Popup()
    {
        Exitpopup.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Exitpopup.SetActive(true);
        }
    }
}

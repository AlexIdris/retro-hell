using UnityEngine;

public class Settings : MonoBehaviour
{
    [SerializeField] GameObject Settingfield;
    [SerializeField] GameObject Quit_Popup;

    private void Start()
    {
        Settingfield.SetActive(false);

    }
    public void settingpanel()
    {
        Settingfield.SetActive(true);
        Quit_Popup.SetActive(false);
    }
}

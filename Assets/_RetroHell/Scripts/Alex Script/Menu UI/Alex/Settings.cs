using UnityEngine;

public class Settings : MonoBehaviour
{
    [SerializeField] GameObject settingfield;
    [SerializeField] GameObject quit_Popup;

    private void Start()
    {
        settingfield.SetActive(false);

    }
    public void settingpanel()
    {
        settingfield.SetActive(true);
        quit_Popup.SetActive(false);
    }
}

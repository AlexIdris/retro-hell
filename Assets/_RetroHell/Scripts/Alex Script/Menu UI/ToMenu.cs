using UnityEngine;

public class ToMenu : MonoBehaviour
{
    [SerializeField] GameObject SettingPanel;
    [SerializeField] GameObject Audio;
    [SerializeField] GameObject Control;
    [SerializeField] GameObject Brief;


    public void Menu()
    {

        SettingPanel.SetActive(false);
        Audio.SetActive(false);
        Brief.SetActive(false);
        Control.SetActive(false);
    }
    public void SettingMenu()
    {
        SettingPanel.SetActive(false);
        Audio.SetActive(false);
        Brief.SetActive(false);
        Control.SetActive(false);
    }





}

using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMenu : MonoBehaviour
{
    [SerializeField] GameObject SettingPanel;
    [SerializeField] GameObject Audio;
    [SerializeField] GameObject Control;
    [SerializeField] GameObject Brief;
    [SerializeField] GameObject QuitPopup;


    public void Menu()
    {

        SettingPanel.SetActive(false);
        Audio.SetActive(false);
        Brief.SetActive(false);
        Control.SetActive(false);
        QuitPopup.SetActive(false);
    }
    public void SettingMenu()
    {
        SettingPanel.SetActive(false);
        Audio.SetActive(false);
        Brief.SetActive(false);
        Control.SetActive(false);
    }
    public void WinMenu()
    {
        SceneManager.LoadScene(0);
    }




}

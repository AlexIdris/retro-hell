using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMenu : MonoBehaviour
{
    [SerializeField] GameObject settingPanel;
    [SerializeField] GameObject inaudio;
    [SerializeField] GameObject control;
    [SerializeField] GameObject brief;
    [SerializeField] GameObject quitPopup;


    public void Menu()
    {

        settingPanel.SetActive(false);
        inaudio.SetActive(false);
        brief.SetActive(false);
        control.SetActive(false);
        quitPopup.SetActive(false);
    }
    public void SettingMenu()
    {
        settingPanel.SetActive(false);
        inaudio.SetActive(false);
        brief.SetActive(false);
        control.SetActive(false);
    }
    public void WinMenu()
    {
        SceneManager.LoadScene(0);
    }




}

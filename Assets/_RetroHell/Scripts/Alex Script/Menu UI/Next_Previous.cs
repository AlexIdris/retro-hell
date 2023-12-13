using UnityEngine;

public class Next_Previous : MonoBehaviour
{
    [SerializeField] GameObject audio;
    [SerializeField] GameObject control;
    [SerializeField] GameObject brief;
    [SerializeField] GameObject settingPanel;
    public void Control()
    {
        audio.SetActive(false);
        brief.SetActive(false);
        control.SetActive(true);
        settingPanel.SetActive(false);
    }
    public void Brief()
    {
        audio.SetActive(false);
        brief.SetActive(true);
        control.SetActive(false);
        settingPanel.SetActive(false);
    }
    public void Audio()
    {
        audio.SetActive(true);
        brief.SetActive(false);
        control.SetActive(false);
        settingPanel.SetActive(false);
    }


}

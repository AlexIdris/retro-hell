using UnityEngine;

public class Settings : MonoBehaviour
{
    [SerializeField] GameObject Settingfield;

    private void Start()
    {
        Settingfield.SetActive(false);
    }
    public void settingpanel()
    {
        Settingfield.SetActive(true);
    }
}

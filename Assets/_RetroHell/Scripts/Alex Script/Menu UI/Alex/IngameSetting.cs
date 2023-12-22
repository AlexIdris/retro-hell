using UnityEngine;

public class IngameSetting : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject settings;
    [SerializeField] GameObject ingamemenu;
    private void Start()
    {
        settings.SetActive(false);
    }
    public void EnterAudioSetting()
    {
        settings.SetActive(true);
    }
    public void ExitAudioSetting()
    {
        settings.SetActive(false);
    }
    public void ExitMenu()
    {
        ingamemenu.SetActive(false);
    }
}

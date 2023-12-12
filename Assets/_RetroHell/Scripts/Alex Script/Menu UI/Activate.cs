using UnityEngine;

public class Activate : MonoBehaviour
{
    [SerializeField] GameObject Audio;
    [SerializeField] GameObject Control;
    [SerializeField] GameObject Brief;

    private void Awake()
    {
        Audio.SetActive(false);
        Control.SetActive(false);
        Brief.SetActive(false);
    }

    public void activateAudio()
    {
        Audio.SetActive(true);
    }
    public void activeControl()
    {
        Control.SetActive(true);
    }
    public void activeBrief()
    {
        Brief.SetActive(true);
    }

}

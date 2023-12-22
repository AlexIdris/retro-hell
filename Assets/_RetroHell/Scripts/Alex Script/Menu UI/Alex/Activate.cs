using UnityEngine;

public class Activate : MonoBehaviour
{
    [SerializeField] GameObject audio;
    [SerializeField] GameObject control;
    [SerializeField] GameObject brief;

    private void Awake()
    {
        audio.SetActive(false);
        control.SetActive(false);
        brief.SetActive(false);
    }

    public void activateAudio()
    {
        audio.SetActive(true);
    }
    public void activeControl()
    {
        control.SetActive(true);
    }
    public void activeBrief()
    {
        brief.SetActive(true);
    }

}

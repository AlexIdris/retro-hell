using UnityEngine;

public class FullScreenToggle : MonoBehaviour
{
    [SerializeField] GameObject checker;

    enum State { On, Off };
    State state;

    private void Start()
    {
        checker.SetActive(true);
        state = State.On;
    }
    public void ToggleFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
        if (state == State.On)
        {
            checker.SetActive(false);
            state = State.Off;
        }
        else if (state == State.Off)
        {
            checker.SetActive(true);
            state = State.On;
        }
    }
    public void Low()
    {
        QualitySettings.SetQualityLevel(0);

    }
    public void Medium()
    {
        QualitySettings.SetQualityLevel(1);
    }
    public void High()
    {
        QualitySettings.SetQualityLevel(2);
    }
}

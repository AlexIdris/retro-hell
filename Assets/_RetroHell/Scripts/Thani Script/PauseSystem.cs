using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseSystem : MonoBehaviour
{
    public bool gamePaused;
    public GameObject pauseScreen;

    void Start()
    {
        Time.timeScale = 1;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused == false)
            {
                Time.timeScale = 0;
                pauseScreen.SetActive(true);
                Debug.Log("Game Paused!");
            }
        }
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
        Debug.Log("Game Resumed!");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Move Test");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}


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
    public void IngamePauseIn()
    {

        if (gamePaused == false)
        {
            Time.timeScale = 0;
            pauseScreen.SetActive(true);
            Debug.Log("Game Paused!");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused == false)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Time.timeScale = 0;
                pauseScreen.SetActive(true);
                Debug.Log("Game Paused!");
            }
        }
    }

    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
        Debug.Log("Game Resumed!");
    }

    public void Restart()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(1);
    }

    public void LoadMainMenu()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(0);
    }
}


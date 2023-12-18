using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseSystem : MonoBehaviour
{
    public bool gamePaused = false;
    [SerializeField] GameObject target;
    public GameObject pauseScreen;

    public void Start()
    {
        Time.timeScale = 1;
    }
    public void BacktoGame()
    {

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
        gamePaused = false;
        pauseScreen.SetActive(false);
        Debug.Log("Game Resumed!");
        target.SetActive(true);
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && gamePaused == false)
        {

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
            pauseScreen.SetActive(true);
            Debug.Log("Game Paused!");
            gamePaused = true;
            target.SetActive(false);

        }
        /* else if (Input.GetKey(KeyCode.Escape) && gamePaused == true)
         {

             Cursor.lockState = CursorLockMode.Locked;
             Cursor.visible = false;
             Time.timeScale = 1;
             pauseScreen.SetActive(false);
             gamePaused = false;


         }*/
    }

    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
        gamePaused = false;
        pauseScreen.SetActive(false);
        Debug.Log("Game Resumed!");
        target.SetActive(true);
    }

    public void Restart()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        SceneManager.LoadScene(1);
        target.SetActive(true);
    }

    public void LoadMainMenu()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(0);
        target.SetActive(false);
    }
}


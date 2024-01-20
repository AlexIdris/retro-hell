using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseSystem : MonoBehaviour
{
    public bool gamePaused = false;
    [SerializeField] GameObject target;
    public GameObject pauseScreen;

    [SerializeField] GameObject gun;


    public void Start()
    {
        Time.timeScale = 1;


        pauseScreen.SetActive(false);
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
        gun.SetActive(true);
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
            gun.SetActive(false);

        }

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
        gun.SetActive(true);
    }

    public void Restart()
    {


        SceneManager.LoadScene(1);
        gun.SetActive(true);
        target.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void Checkpoint1()
    {


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gun.SetActive(true);
        target.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }
    public void Checkpoint2()
    {


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gun.SetActive(true);
        target.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void LoadMainMenu()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(0);
        target.SetActive(false);
        gun.SetActive(true);
    }
}


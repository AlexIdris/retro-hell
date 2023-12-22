using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    [SerializeField] GameObject mainMenuAudio;


    public void ToGame()
    {

        mainMenuAudio.SetActive(false);
        SceneManager.LoadScene(1);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;

    }
    private void Update()
    {


    }
}

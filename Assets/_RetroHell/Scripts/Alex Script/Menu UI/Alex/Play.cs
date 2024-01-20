using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    [SerializeField] GameObject mainMenuAudio;


    public void ToGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        mainMenuAudio.SetActive(false);
        SceneManager.LoadScene(1);


    }
    private void Update()
    {


    }
}

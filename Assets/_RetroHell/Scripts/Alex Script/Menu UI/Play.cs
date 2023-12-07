using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{



    public void ToGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        SceneManager.LoadScene(1);

    }
    private void Update()
    {


    }
}

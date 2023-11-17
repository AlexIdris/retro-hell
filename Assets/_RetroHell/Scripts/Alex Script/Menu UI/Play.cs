using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void ToGame()
    {
        SceneManager.LoadScene(0);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_Previous : MonoBehaviour
{
    public void Next()
    {
        SceneManager.LoadScene(3);
    }
    public void Previous()
    {
        SceneManager.LoadScene(2);
    }

}

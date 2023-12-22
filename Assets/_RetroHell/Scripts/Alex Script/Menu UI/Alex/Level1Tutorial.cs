using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Tutorial : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        if (other.tag is "Player")
        {
            SceneManager.LoadScene(1);
        }
    }
}

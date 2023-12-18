using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial_Level1 : MonoBehaviour
{
    // Start is called before the first frame update


    private void OnTriggerStay(Collider other)
    {
        if (other.tag is "Player")
        {
            SceneManager.LoadScene(2);

        }
    }
}

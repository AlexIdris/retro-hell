using UnityEngine;
using UnityEngine.UI;

public class slowMotion : MonoBehaviour
{
    bool slowMo = false;
    float slowMoSpeed = 0.5f;
    float normSpeed = 1.0f;
    [SerializeField] Button button;
    [SerializeField] bool buttonInteractable = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            slowMo = true;
            Time.timeScale = slowMoSpeed;
            buttonInteractable = false;

        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            slowMo = false;
            Time.timeScale = normSpeed;
            buttonInteractable = true;
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class slowMotion : MonoBehaviour
{
    bool slowMo = false;
    float slowMoSpeed = 0.5f;
    float normSpeed = 1.0f;
    [SerializeField] Button button;


    // Start is called before the first frame update
    void Start()
    {
        button.interactable = true;
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            slowMo = true;
            Time.timeScale = slowMoSpeed;
            button.onClick.Invoke();


        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            slowMo = false;
            Time.timeScale = normSpeed;
            button.interactable = false;
        }
        return;

    }
}

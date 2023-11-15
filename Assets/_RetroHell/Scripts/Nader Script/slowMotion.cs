using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class slowMotion : MonoBehaviour
{
    bool slowMo = false;
    float slowMoSpeed = 0.5f;
    float normSpeed = 1.0f;
    [SerializeField] Button button;
    [SerializeField] GameObject SlowmoFrame;
    [SerializeField] TMP_Text EText;
    [SerializeField] float delayTime = 2f;


    // Start is called before the first frame update
    void Start()
    {
        button.interactable = true;
        SlowmoFrame.SetActive(true);
        EText.gameObject.SetActive(true);

    }

    // Update is called once per frame
    public void Update()
    {
        Slowdowntime();
        Normaltime();

    }
    void Slowdowntime()
    {


        if (Input.GetKeyDown(KeyCode.E))
        {

            slowMo = true;
            Time.timeScale = slowMoSpeed;
            button.onClick.Invoke();
            SlowmoFrame.SetActive(true);
            EText.gameObject.SetActive(true);

        }
    }
    void Normaltime()
    {

        if (Input.GetKeyUp(KeyCode.E))
        {
            slowMo = false;
            Time.timeScale = normSpeed;
            button.interactable = false;
            SlowmoFrame.SetActive(false);
            EText.gameObject.SetActive(false);


        }
    }
}

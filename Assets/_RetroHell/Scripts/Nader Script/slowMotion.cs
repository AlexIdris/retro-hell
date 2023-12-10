using System.Threading.Tasks;
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
    [SerializeField] float cooldownTime = 5f;
    [SerializeField] float cooldownTimer = 0f;
    [SerializeField] bool isCooldown = true;
    [SerializeField] float last;



    // Start is called before the first frame update
    void Start()
    {
        button.interactable = true;
        SlowmoFrame.SetActive(true);
        EText.gameObject.SetActive(true);


    }

    // Update is called once per frame
    public async void Update()
    {
        if (isCooldown)
        {

            cooldownTimer -= Time.deltaTime;

            if (cooldownTimer <= 0)
            {
                isCooldown = false;
                cooldownTimer = 0f;
            }
        }
        if (!isCooldown)
        {
            Slowdowntime();
        }

    }

    private async void Slowdowntime()
    {
        button.interactable = true;
        SlowmoFrame.SetActive(true);
        EText.gameObject.SetActive(true);

        if (Input.GetKey(KeyCode.E) && !isCooldown)
        {

            slowMo = true;
            Time.timeScale = slowMoSpeed;

            await Task.Delay(2000);

            slowMo = false;
            Time.timeScale = normSpeed;
            button.interactable = false;
            SlowmoFrame.SetActive(false);
            EText.gameObject.SetActive(false);

            isCooldown = true;
            cooldownTimer = cooldownTime;



        }

    }
}

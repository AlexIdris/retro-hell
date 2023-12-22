using UnityEngine;

public class QuitPopup : MonoBehaviour
{
    [SerializeField] GameObject exitpopup;


    private void Awake()
    {
        exitpopup.SetActive(false);



    }
    public void Popup()
    {
        exitpopup.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            exitpopup.SetActive(true);

        }

    }
}

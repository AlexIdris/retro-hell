using UnityEngine;

public class Intro : MonoBehaviour
{
    [SerializeField] GameObject introone;
    [SerializeField] GameObject introtwo;
    [SerializeField] GameObject player;
    [SerializeField] GameObject menu;

    void Awake()
    {
        introone.SetActive(true);
        introtwo.SetActive(false);
        player.SetActive(false);
        menu.SetActive(false);
    }
    public void secondintro()
    {
        introone.SetActive(false);
        introtwo.SetActive(true);
        player.SetActive(false);
        menu.SetActive(false);
    }
    public void game()
    {
        introone.SetActive(false);
        introtwo.SetActive(false);
        player.SetActive(true);
        menu.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

}

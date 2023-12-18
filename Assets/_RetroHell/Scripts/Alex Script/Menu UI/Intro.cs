using UnityEngine;

public class Intro : MonoBehaviour
{
    [SerializeField] GameObject Introone;
    [SerializeField] GameObject Introtwo;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Menu;

    void Awake()
    {
        Introone.SetActive(true);
        Introtwo.SetActive(false);
        Player.SetActive(false);
        Menu.SetActive(false);
    }
    public void secondintro()
    {
        Introone.SetActive(false);
        Introtwo.SetActive(true);
        Player.SetActive(false);
        Menu.SetActive(false);
    }
    public void game()
    {
        Introone.SetActive(false);
        Introtwo.SetActive(false);
        Player.SetActive(true);
        Menu.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

}

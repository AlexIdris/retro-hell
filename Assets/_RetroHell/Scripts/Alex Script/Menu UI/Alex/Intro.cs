using UnityEngine;

public class Intro : MonoBehaviour
{
    [SerializeField] GameObject introone;
    [SerializeField] GameObject introtwo;
    [SerializeField] GameObject introthree;
    [SerializeField] GameObject player;
    [SerializeField] GameObject menu;
    [SerializeField] GameObject target;
    void Awake()
    {
        introthree.SetActive(true);
        introone.SetActive(true);
        introtwo.SetActive(true);
        player.SetActive(false);
        menu.SetActive(false);
        target.SetActive(true);
    }
    public void secondintro()
    {
        introone.SetActive(false);
        introtwo.SetActive(true);
        introthree.SetActive(false);
        player.SetActive(false);

        menu.SetActive(false);
    }
    public void thirdintro()
    {
        introthree.SetActive(true);
        introone.SetActive(false);
        introtwo.SetActive(false);
        player.SetActive(false);

        menu.SetActive(false);
    }
    public void game()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        introone.SetActive(false);
        introtwo.SetActive(false);
        introthree.SetActive(false);
        player.SetActive(true);
        target.SetActive(false);
        menu.SetActive(false);

    }

}

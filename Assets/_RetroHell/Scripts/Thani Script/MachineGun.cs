using TMPro;
using UnityEngine;

public class MachineGun : MonoBehaviour
{
    public Player_Control player;
    public PlayerShooting playerControls;

    public GameObject animatorObject;
    public PowerUpIconAnimator animator;

    [SerializeField] TMP_Text bullettext;
    [SerializeField] GameObject machineGun;
    [SerializeField] int maxAmmo = 50;

    public void Awake()
    {
        animatorObject = GameObject.FindGameObjectWithTag("Animator");
        animator = animator.GetComponent<PowerUpIconAnimator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            playerControls.machineGunObtained = true;
            playerControls.machineGunBullets = maxAmmo;
            animator.MGAnimation();
            machineGun.SetActive(true);
            bullettext.text = playerControls.machineGunBullets.ToString();
            Destroy(gameObject);
        }
    }
}

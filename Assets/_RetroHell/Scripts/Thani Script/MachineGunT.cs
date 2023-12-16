using TMPro;
using UnityEngine;

public class MachineGunT : MonoBehaviour
{
    public Player_Control player;
    public PlayerShooting playerControls;

    public GameObject animatorObject;
    public PowerUpIconAnimator animator;
    [SerializeField] GameObject IW_MachineGun;
    [SerializeField] AudioSource audioSource;
    [SerializeField] TMP_Text bullettext;
    public GameObject machineGun;
    [SerializeField] int maxAmmo = 50;


    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Control>();
        playerControls = GameObject.FindGameObjectWithTag("Gun").GetComponent<PlayerShooting>();
        machineGun.SetActive(false);
        animatorObject = GameObject.FindGameObjectWithTag("Animator");
        animator = animatorObject.GetComponent<PowerUpIconAnimator>();


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            playerControls.machineGunObtained = true;
            playerControls.machineGunBullets = maxAmmo;
            machineGun.SetActive(true);
            animator.MGAnimation();

            bullettext.text = playerControls.machineGunBullets.ToString();
            IW_MachineGun.SetActive(false);
            audioSource.Play();
            Destroy(gameObject);
        }


    }

}

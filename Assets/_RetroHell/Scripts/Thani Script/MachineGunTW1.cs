using TMPro;
using UnityEngine;

public class MachineGunTW1 : MonoBehaviour
{
    public Player_Control player;
    public PlayerShooting playerControls;
    public GameObject animatorObject;
    public PowerUpIconAnimator animator;
    [SerializeField] GameObject IW_MachineGun;
    [SerializeField] AudioSource audioSource;
    [SerializeField] TMP_Text bullettext;
    public GameObject machineGun;
    [SerializeField] int maxAmmo = 30;



    public void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Control>();

        machineGun.SetActive(false);
        animatorObject = GameObject.FindGameObjectWithTag("Animator");
        animator = animatorObject.GetComponent<PowerUpIconAnimator>();
        audioSource.Stop();


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

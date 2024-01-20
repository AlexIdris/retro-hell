using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class MachineGunT : MonoBehaviour
{
    public Player_Control player;
    public PlayerShooting playerControls;
    [SerializeField] TMP_Text achievementText;
    [SerializeField] GameObject achievementPopup;
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
            animator.MGAnimation();
            bullettext.text = playerControls.machineGunBullets.ToString();
            machineGun.SetActive(true);
            IW_MachineGun.SetActive(false);
            audioSource.Play();
            Destroy(gameObject);

        }


    }
    private async void OnDestroy()
    {

        achievementPopup.SetActive(true);
        achievementText.text = "*Hellraiser 30K aquired*\n" +
                 "Right-Click to fire.";
        await Task.Delay(3000);
        achievementPopup.SetActive(false);


    }
}

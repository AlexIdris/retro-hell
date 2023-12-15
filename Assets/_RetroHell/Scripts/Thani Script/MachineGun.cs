using TMPro;
using UnityEngine;

public class MachineGun : MonoBehaviour
{
    [SerializeField] private Player_Control player;
    [SerializeField] PlayerShooting playerControls;
    [SerializeField] WeaponManager weaponManager;
    [SerializeField] GameObject animatorObject;
    [SerializeField] PowerUpIconAnimator animator;
    [SerializeField] AudioSource audioSource;
    [SerializeField] TMP_Text bullettext;
    [SerializeField] GameObject machineGun;
    [SerializeField] int maxAmmo = 50;
    [SerializeField] float dispawntimer = 10;

    public float MGItemTimer;



    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Control>();
        playerControls = GameObject.FindGameObjectWithTag("Gun").GetComponent<PlayerShooting>();
        animatorObject = GameObject.FindGameObjectWithTag("Animator");
        animator = animatorObject.GetComponent<PowerUpIconAnimator>();
        weaponManager.gamestart();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag is "Player")
        {
            weaponManager.assult();
            playerControls.machineGunObtained = true;
            playerControls.machineGunBullets = maxAmmo;
            animator.MGAnimation();
            bullettext.text = playerControls.machineGunBullets.ToString();
            audioSource.Play();
            Destroy(gameObject);
        }
    }


    public void FixedUpdate()
    {
        MGItemTimer += Time.deltaTime;

        if (MGItemTimer > dispawntimer)
        {
            Destroy(gameObject);
        }
    }
}

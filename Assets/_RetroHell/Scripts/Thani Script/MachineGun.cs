using TMPro;
using UnityEngine;

public class MachineGun : MonoBehaviour
{
    [SerializeField] Player_Control player;
    [SerializeField] PlayerShooting playerControls;

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
        machineGun = GameObject.FindGameObjectWithTag("GunHUD");
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
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        audioSource.Play();
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

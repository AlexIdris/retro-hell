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

    public float timer;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Control>(); ;
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
            animator.MGAnimation();
            machineGun.SetActive(true);
            bullettext.text = playerControls.machineGunBullets.ToString();
            Destroy(gameObject);
        }
    }

    public void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer > 10)
        {
            Destroy(gameObject);
        }
    }
}

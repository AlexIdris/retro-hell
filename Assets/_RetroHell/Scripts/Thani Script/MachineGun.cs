using TMPro;
using UnityEngine;

public class MachineGun : MonoBehaviour
{
    public Player_Control player;
    public PlayerShooting playerControls;
    public GameObject machineGun;
    public GameObject animatorObject;
    public PowerUpIconAnimator animator;

    public TMP_Text bullettext;
    [SerializeField] int maxAmmo = 50;
    [SerializeField] float dispawntimer = 10;
    [SerializeField] AudioSource audioSource;

    public float MGItemTimer;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Control>();
        playerControls = GameObject.FindGameObjectWithTag("Gun").GetComponent<PlayerShooting>();

        machineGun = FindInActiveObjectByTag("GunHUD");
        bullettext = FindInActiveObjectByTag("MG Bullet Counter").GetComponent<TMP_Text>();
        audioSource = FindInActiveObjectByTag("Drop Audio").GetComponent<AudioSource>();
        audioSource.Stop();
        animatorObject = GameObject.FindGameObjectWithTag("Animator");
        animator = animatorObject.GetComponent<PowerUpIconAnimator>();

    }

    GameObject FindInActiveObjectByTag(string tag)
    {
        Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>();
        for (int i = 0; i < objs.Length; i++)
        {
            if (objs[i].hideFlags == HideFlags.None)
            {
                if (objs[i].CompareTag(tag))
                {
                    return objs[i].gameObject;
                }
            }
        }
        return null;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag is "Player")
        {

            playerControls.machineGunObtained = true;
            playerControls.machineGunBullets = maxAmmo;
            machineGun.SetActive(true);
            animator.MGAnimation();
            audioSource.Play();
            bullettext.text = playerControls.machineGunBullets.ToString();
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

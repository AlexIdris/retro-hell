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

    public float MGItemTimer;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Control>();
        playerControls = GameObject.FindGameObjectWithTag("Gun").GetComponent<PlayerShooting>();

        machineGun = FindInActiveObjectByTag("GunHUD");
        bullettext = FindInActiveObjectByTag("MG Bullet Counter").GetComponent<TMP_Text>();

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
        MGItemTimer += Time.deltaTime;

        if (MGItemTimer > 5)
        {
            Destroy(gameObject);
        }
    }
}

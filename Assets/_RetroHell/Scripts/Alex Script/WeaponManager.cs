using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public GameObject Pistol;
    public GameObject Assualt;
    // Start is called before the first frame update
    public void gamestart()
    {
        Pistol.SetActive(true);
        Assualt.SetActive(false);
    }
    public void assult()
    {
        Assualt.SetActive(true);
    }



}

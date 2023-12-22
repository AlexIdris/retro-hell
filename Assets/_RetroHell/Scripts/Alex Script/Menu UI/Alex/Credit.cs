using UnityEngine;

public class Credit : MonoBehaviour
{
    [SerializeField] GameObject credit;
    // Start is called before the first frame update
    private void Start()
    {
        credit.SetActive(false);
    }
    public void AssetList()
    {
        credit.SetActive(true);
    }


}

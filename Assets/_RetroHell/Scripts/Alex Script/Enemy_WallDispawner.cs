using UnityEngine;

public class Enemy_WallDispawner : MonoBehaviour
{
    [SerializeField] GameObject Minion1;
    [SerializeField] GameObject Minion2;
    [SerializeField] GameObject Minion3;
    [SerializeField] GameObject IW_Minion;

    private void Start()
    {

        IW_Minion.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        if ((Minion1 = null) && (Minion2 = null) && (Minion3 = null))
        {
            IW_Minion.SetActive(false);
        }
    }
}

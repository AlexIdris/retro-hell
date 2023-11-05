using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] Slider bar;

    public void MaxHealth(int playerHealth)
    {
        bar.maxValue = playerHealth;
    }

    public void ChangeHealth(int playerHealth)
    {
        bar.value = playerHealth;
    }
}

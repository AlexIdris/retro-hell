using UnityEngine;
using UnityEngine.UI;

public class Miniturrent_Health : MonoBehaviour
{
    [SerializeField] Slider slider;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }
}

using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public Slider bar;
    public bool fullHealth = true;
    public int playerHealth;/*

    private void Update()
    {
        if (fullHealth)
        {
            MaxHealth(playerHealth);
        }
        else if (!fullHealth)
        {
            ChangeHealth(playerHealth);
        }
    }*/
    public void MaxHealth(int playerHealth)
    {

        bar.maxValue = playerHealth;
        bar.value = playerHealth;


    }

    public void ChangeHealth(int playerHealth)
    {
        bar.value = playerHealth;
        fullHealth = false;
    }
}

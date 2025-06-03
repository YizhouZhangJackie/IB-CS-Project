using UnityEngine;
using UnityEngine.UI;

public class TowerScript : MonoBehaviour
{
    private int maxHealth;
    private int health;
    [SerializeField] private GameObject slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxHealth = 100;
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getDamaged(int amount)
    {
        health -= amount;
        slider.GetComponent<HealthBarScript>().updateHealthBar((float)health / maxHealth);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;
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
        if(health <= 0)
        {
            SceneManager.LoadSceneAsync("Game Over");
        }
    }

    public void getDamaged(int amount)
    {
        health -= amount;
        slider.GetComponent<HealthBarScript>().updateHealthBar((float)health / maxHealth);
    }
}

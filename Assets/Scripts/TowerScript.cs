using UnityEngine;

public class TowerScript : MonoBehaviour
{
    private int health;
    [SerializeField] private GameObject slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getDamaged(int amount)
    {
        health -= amount;

    }
}

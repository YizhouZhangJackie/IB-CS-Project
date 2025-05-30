using UnityEngine;
using Unity.Collections;
using System.Collections.Generic;

public class DamageScript : MonoBehaviour
{
    public Dictionary<string, int> enemyToDamage= new Dictionary<string, int>();
    public Dictionary<string, int> attackToDamage = new Dictionary<string, int>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        attackToDamage.Add("Bullet", 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

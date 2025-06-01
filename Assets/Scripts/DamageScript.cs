using UnityEngine;
using Unity.Collections;
using System.Collections.Generic;

public class DamageScript : MonoBehaviour
{
    public static Dictionary<string, int> enemyToDamage;
    public static Dictionary<string, int> attackToDamage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        attackToDamage = new Dictionary<string, int>();
        enemyToDamage = new Dictionary<string, int>();
        attackToDamage.Add("Bullet(Clone)", 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getAtkDamage(string attack)
    {
        return attackToDamage[attack];
    }
}

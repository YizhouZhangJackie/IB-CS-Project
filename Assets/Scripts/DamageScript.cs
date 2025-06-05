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
        attackToDamage.Add("Bullet(Clone)", 40);
        attackToDamage.Add("Laser(Clone)", 20);
        attackToDamage.Add("ElectricBullet(Clone)", 25);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getAtkDamage(string attack)
    {
        Debug.Log(attack);
        return attackToDamage[attack];
    }
}

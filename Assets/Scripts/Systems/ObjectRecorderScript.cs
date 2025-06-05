using UnityEngine;
using Unity.Collections;
using System.Collections.Generic;

public class ObjectRecorderScript : MonoBehaviour
{
    [SerializeField] private List<GameObject> allTowers;
    public Dictionary<GameObject, float> towerToHealth;
    public GameObject leftMost;
    public float smallestX;

    void Start()
    {
        allTowers = new List<GameObject>();
        allTowers.Add(GameObject.Find("Tower"));
        leftMost = allTowers[0];
        smallestX = allTowers[0].transform.position.x;
        towerToHealth = new Dictionary<GameObject, float>();
        towerToHealth.Add(allTowers[0], 100);
    }

    public void addTowers(GameObject tower, float health)
    {
        allTowers.Add(tower);
        towerToHealth.Add(tower, health);
        float x = tower.transform.position.x;
        if(x < smallestX)
        {
            smallestX = x;
            leftMost = tower;
        }
    }
    public void removeTowers(GameObject tower)
    {
        allTowers.Remove(tower);
        towerToHealth.Remove(tower);
        float x = tower.transform.position.x;
        if(x == smallestX)
        {
            float minx = 1000;
            for(int i = 0; i < allTowers.Count; i++)
            {
                if(minx > allTowers[i].transform.position.x)
                {
                    minx = allTowers[i].transform.position.x;
                    leftMost = allTowers[i];
                }
            }
            smallestX = minx;
        }
    }

    public void deductHealth(GameObject tower,float amount)
    {
        towerToHealth[tower] -= amount;
        if (towerToHealth[tower] <= 0)
        {
            removeTowers(tower);
            Destroy(tower);
        }
    }
}

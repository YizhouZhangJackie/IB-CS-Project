using UnityEngine;
using Unity.Collections;
using System.Collections.Generic;

public class ObjectRecorderScript : MonoBehaviour
{
    private static List<GameObject> allTowers;
    public GameObject leftMost;
    public float smallestX;

    void Start()
    {
        allTowers = new List<GameObject>();
        allTowers.Add(GameObject.Find("Tower"));
        leftMost = allTowers[0];
        smallestX = allTowers[0].transform.position.x;
    }

    public void addTowers(GameObject tower)
    {
        allTowers.Add(tower);
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

}

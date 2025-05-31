using UnityEngine;
using System.Collections.Generic;

public class EnemySpawningScript : MonoBehaviour
{
    public static List<GameObject> allEnemies = new List<GameObject>();
    [SerializeField] private GameObject basicEnemy;
    [SerializeField] private GameObject tower;
    private int numEnemies;
    private int numSpawned;
    private float frequency = 1.5f;
    private float currTime;
    private int wave;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        frequency = 1.5f;
        currTime = frequency;
        numEnemies = 10;
        numSpawned = 100;
    }

    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;
        if (numSpawned < numEnemies && currTime >= frequency)
        {
            numSpawned++;
            currTime = 0;
            GameObject enemy = Instantiate(basicEnemy, transform.position, transform.rotation);
            enemy.GetComponent<Enemy>().setEnemyBase(tower);
            allEnemies.Add(enemy);
        }
    }

    public void spawnWave(int wave)
    {
        numSpawned = 0;
        this.wave = wave;
    }
}

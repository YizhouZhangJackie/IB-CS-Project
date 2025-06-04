using UnityEngine;
using System.Collections.Generic;

public class EnemySpawningScript : MonoBehaviour
{
    public List<GameObject> allEnemies = new List<GameObject>();
    [SerializeField] private GameObject basicEnemy;
    [SerializeField] private GameObject tankEnemy;
    [SerializeField] private GameObject fastEnemy;
    [SerializeField] private GameObject bossEnemy;
    [SerializeField] private GameObject tower;
    [SerializeField] private GameObject WaveSystem;
    private List<(int, float, int)>[] wavesEnemies;
    private int numEnemies;
    private int numSpawned;
    private float frequency = 1.5f;
    private float currTime;
    private int wave;
    public float rightMostX;
    private int index;
    private bool flag;
    private bool flag2;
    private GameObject enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        frequency = 0;
        currTime = frequency;
        numEnemies = 0;
        numSpawned = 0;
        rightMostX = -100;
        index = 0;
        wavesEnemies = new List<(int, float, int)>[21];
        initializeWaves();
        flag = false;
        flag2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            currTime += Time.deltaTime;
            if (index < wavesEnemies[wave].Count && currTime >= frequency)
            {
                currTime = 0;
                numEnemies = wavesEnemies[wave][index].Item3;
                spawnEnemy(wavesEnemies[wave][index].Item1);
                if (numEnemies == numSpawned)
                {
                    numSpawned = 0;
                    index++;
                    
                    if (index == wavesEnemies[wave].Count)
                    {
                        flag = false;
                    }
                }
            }
        }

        if (!flag && flag2 && allEnemies.Count == 0)
        {
            WaveSystem.GetComponent<WaveSystemScript>().nextWave();
            flag2 = false;
        }
        if (allEnemies.Count == 0)
        {
            if(wave != 0 && !flag)
            {
                index = 0;
                frequency = wavesEnemies[wave + 1][index].Item2;
            }
            rightMostX = -50;
        }
        for (int i = 0; i < allEnemies.Count; i++)
        {
            rightMostX = Mathf.Max(rightMostX, allEnemies[i].transform.position.x);
        }
    }


    private void initializeWaves()
    {
        //enemyType, cooldown, amount
        wavesEnemies[1] = new List<(int, float, int)> { (1, 1, 5) };
        wavesEnemies[2] = new List<(int, float, int)> { (1, 0.9f, 10) };
        wavesEnemies[3] = new List<(int, float, int)> { (2, 1, 1), (1, 1, 4), (2, 3, 1), (1, 1, 4)};
        wavesEnemies[4] = new List<(int, float, int)> { (2, 1, 2), (1, 1, 3), (2, 2, 2), (1, 1, 3)};
        wavesEnemies[5] = new List<(int, float, int)> { (1, 0.5f, 9), (3, 2, 1) };
        wavesEnemies[6] = new List<(int, float, int)> { (2, 2, 3), (3, 1, 2), (1, 1, 5) };
        wavesEnemies[7] = new List<(int, float, int)> { (2, 2, 5), (3, 1, 5) };
        wavesEnemies[8] = new List<(int, float, int)> { (3, 0.5f, 3), (2, 1f, 3), (3, 0.5f, 4) };
        wavesEnemies[9] = new List<(int, float, int)> { (1, 0.5f, 5), (2, 2, 1), (2, 0.5f, 4), (3, 2, 1), (3, 0.5f, 4)};
        wavesEnemies[10] = new List<(int, float, int)> { (4, 1, 1) };
        wavesEnemies[11] = new List<(int, float, int)> { (3, 0.3f, 20) };
        wavesEnemies[12] = new List<(int, float, int)> { (1, 0.5f, 10), (3, 0.5f, 10) };
        wavesEnemies[13] = new List<(int, float, int)> { (4, 1, 1), (2, 0.5f, 3), (1, 1, 10) };
        wavesEnemies[14] = new List<(int, float, int)> { (2, 0.5f, 3), (2, 2, 1), (2, 0.5f, 2), (2, 2, 1), (2, 0.5f, 2), (2, 2, 1), (2, 0.5f, 2) };
        wavesEnemies[15] = new List<(int, float, int)> { (2, 0.5f, 3), (4, 2, 1), (3, 2, 10)};
        wavesEnemies[16] = new List<(int, float, int)> { (1, 0.5f, 5), (3, 0.2f, 20) };
        wavesEnemies[17] = new List<(int, float, int)> { (2, 1, 20) };
        wavesEnemies[18] = new List<(int, float, int)> { (2, 0.5f, 30) };
        wavesEnemies[19] = new List<(int, float, int)> { (2, 0.5f, 15), (3, 0.5f, 15) };
        wavesEnemies[20] = new List<(int, float, int)> { (4, 1, 2), (2, 0.5f, 3), (3, 0.2f, 30)};
    }
    private void spawnEnemy(int enemyType)
    {
        switch (enemyType)
        {
            case 1:
                enemy = Instantiate(basicEnemy, transform.position, transform.rotation);
                break;
            case 2:
                enemy = Instantiate(tankEnemy, transform.position, transform.rotation);
                break;
            case 3:
                enemy = Instantiate(fastEnemy, transform.position, transform.rotation);
                break;
            case 4:
                enemy = Instantiate(bossEnemy, transform.position, transform.rotation);
                break;
        }
        numSpawned++;
        enemy.GetComponent<Enemy>().setEnemyBase(tower);
        allEnemies.Add(enemy);
    }

    public void spawnWave(int wave)
    {
        flag = true;
        flag2 = true;
        frequency = wavesEnemies[wave][0].Item2;
        numSpawned = 0;
        this.wave = wave;
    }
}

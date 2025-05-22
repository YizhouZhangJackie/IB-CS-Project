using UnityEngine;

public class EnemySpawningScript : MonoBehaviour
{
    [SerializeField] private GameObject basicEnemy;
    [SerializeField] private GameObject tower;
    private int numEnemies;
    private int numSpawned;
    private float frequency = 0.5f;
    private float currTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currTime = 0.5f;
        frequency = 0.5f;
        numEnemies = 20;
        numSpawned = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnWave(int wave)
    {
        currTime += Time.deltaTime;
        if (currTime >= frequency)
        {
            currTime = 0;
            GameObject enemy = Instantiate(basicEnemy, transform.position, transform.rotation);
            enemy.GetComponent<Enemy>().setEnemyBase(tower);
        }
    }
}

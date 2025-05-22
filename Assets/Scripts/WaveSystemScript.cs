using UnityEngine;

public class WaveSystemScript : MonoBehaviour
{
    [SerializeField] private GameObject enemySpawnSystem;
    private int frequency;
    private float currTime;
    private int waveNum;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        frequency = 30;
        currTime = 30;
        waveNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;
        if(currTime >= frequency)
        {
            currTime = 0;
            waveNum++;
            enemySpawnSystem.GetComponent<EnemySpawningScript>().spawnWave(waveNum);
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class WaveSystemScript : MonoBehaviour
{
    [SerializeField] private GameObject enemySpawnSystem;
    public int frequency;
    public float currTime;
    public int waveNum;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        frequency = 45;
        currTime = 45;
        waveNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;
        if(currTime > frequency)
        {
            currTime = 0;
            waveNum++;
            enemySpawnSystem.GetComponent<EnemySpawningScript>().spawnWave(waveNum);
        }
        if(waveNum == 21)
        {
            SceneManager.LoadScene("You Win");
        }
    }

    public void nextWave()
    {
        currTime = frequency - 5;
    }
}

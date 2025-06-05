using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected float amplifier;
    protected float range;
    [SerializeField] protected float health;
    protected float damage;
    protected int frequency;
    protected float speed;
    protected float currentTime;
    public GameObject enemyBase;
    public GameObject enemy;
    [SerializeField] private WaveSystemScript waveSystem;
    [SerializeField] protected resourceSystemScript resourceSystem;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected void Start()
    {
        waveSystem = GameObject.Find("WaveSystem").GetComponent<WaveSystemScript>();
        resourceSystem = GameObject.Find("ResourceSystem").GetComponent<resourceSystemScript>();
        amplifier = waveSystem.waveNum / 7f + 1;
    }

    // Update is called once per frame
    protected void Update()
    {
        if(!isBaseInRange())
        {
            currentTime = 100;
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            
        } else
        {
            currentTime += Time.deltaTime;
            if(currentTime >= frequency)
            {
                currentTime = 0;
                attack(enemy);
            }
        }
        if(health <= 0)
        {
            die();
        }
    }

    virtual public void setEnemyBase(GameObject enemybase)
    {
        enemyBase = enemybase;
    }

    virtual public bool isBaseInRange()
    {
        return false;
    }

    virtual public bool isEnemyInRange()
    {
        return false;
    }

    virtual public void attack(GameObject target)
    {
        
    }

    virtual public void takeDamage(int damageTaken)
    {
        health -= damageTaken;
    }

    virtual public void die()
    {
        GameObject.Find("EnemySpawnSystem").GetComponent<EnemySpawningScript>().allEnemies.Remove(this.gameObject);
        Destroy(this.gameObject);
    }

    
}

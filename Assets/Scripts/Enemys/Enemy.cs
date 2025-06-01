using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected float amplifier;
    protected float range;
    [SerializeField] protected int health;
    protected int damage;
    protected int frequency;
    protected float speed;
    protected float currentTime;
    public GameObject enemyBase;
    public GameObject enemy;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    protected void Update()
    {
        if(!isBaseInRange())
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            
        } else
        {
            attack(enemy);
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
        Destroy(this.gameObject);
    }

    
}

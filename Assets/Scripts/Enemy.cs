using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected float amplifier;
    protected float range;
    protected int health;
    protected int damage;
    protected int frequency;
    protected float speed;
    private float currentTime;
    public GameObject enemyBase;
    public GameObject enemy;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    protected void Update()
    {
        if(!isBaseInRange() && !isEnemyInRange())
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            
        } else if (isBaseInRange())
        {
            attack(enemyBase);
        } else
        {
            attack(enemy);
        }
        if(health <= 0)
        {
            die();
        }
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

    virtual public void die()
    {

    }
}

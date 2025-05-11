using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected int amplifier;
    protected int range;
    protected int velocity;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!isBaseInRange() || !isEnemyInRange())
        {

        } else if (isBaseInRange())
        {

        } else
        {

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

    virtual public void attack()
    {

    }
}

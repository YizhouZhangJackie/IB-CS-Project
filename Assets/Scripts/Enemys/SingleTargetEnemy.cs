using UnityEngine;

public class SingleTargetEnemy : Enemy
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }

    public override bool isBaseInRange()
    {
        if(Mathf.Abs(enemyBase.transform.position.x - transform.position.x) <= range)
        {
            return true;
        } else
        {
            return false;
        }
    }

    public override bool isEnemyInRange()
    {
        return false;
    }
}

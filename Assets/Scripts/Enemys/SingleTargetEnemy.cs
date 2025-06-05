using UnityEngine;

public class SingleTargetEnemy : Enemy
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    new void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }

    public override bool isBaseInRange()
    {
        if(Mathf.Abs(GameObject.Find("ObjectRecorder").GetComponent<ObjectRecorderScript>().smallestX - transform.position.x) <= range)
        {
            enemy = GameObject.Find("ObjectRecorder").GetComponent<ObjectRecorderScript>().leftMost;
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

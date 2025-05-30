using UnityEngine;

public class NormalEnemy : SingleTargetEnemy
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        amplifier = 1;
        range = 1.1f;
        health = 50;
        damage = 8;
        frequency = 47;
        speed = 0.5f;
        currentTime = frequency;
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }

    public override void attack(GameObject target)
    {
        currentTime += Time.deltaTime;
        //animation
        if (currentTime >= frequency/20)
        {
            currentTime = 0;
            target.GetComponent<TowerScript>().getDamaged(10);
        }
    }
}

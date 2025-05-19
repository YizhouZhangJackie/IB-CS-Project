using UnityEngine;

public class NormalEnemy : SingleTargetEnemy
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        amplifier = 1;
        range = 1.1f;
        health = 90;
        damage = 8;
        frequency = 47;
        speed = 0.5f;

    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }
}

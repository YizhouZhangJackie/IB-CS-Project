using UnityEngine;

public class ElectricBulletScript : BulletScript
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bulletSpeed = 5;
        pierce = 3;
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }
}

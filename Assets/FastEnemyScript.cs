using UnityEngine;

public class FastEnemyScript : SingleTargetEnemy
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        amplifier = 1;
        range = 1.1f;
        health = 25;
        damage = 5;
        frequency = 2;
        speed = 2f;
        currentTime = frequency;
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }

    public override void attack(GameObject target)
    {
        if (target.GetComponent<TowerScript>() != null)
        {
            target.GetComponent<TowerScript>().getDamaged(damage);
        }
        else
        {
            GameObject.Find("ObjectRecorder").GetComponent<ObjectRecorderScript>().deductHealth(target, damage);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Attack")
        {
            takeDamage(GameObject.Find("DamageSystem").GetComponent<DamageScript>().getAtkDamage(collision.gameObject.name));
        }
    }
}

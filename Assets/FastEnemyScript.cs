using UnityEngine;

public class FastEnemyScript : SingleTargetEnemy
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    new void Start()
    {
        base.Start();
        range = 1.1f;
        health = 25 * amplifier;
        damage = 5 * amplifier;
        frequency = 2;
        speed = 2f * amplifier;
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

    public override void die()
    {
        resourceSystem.coinAmount += 20;
        base.die();
    }
}

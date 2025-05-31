using UnityEngine;

public class ShooterScript : WeaponScript
{
    protected string rarity;
    [SerializeField] private GameObject bullet;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        atkFreq = 1;
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }

    public override void attack()
    {
        Instantiate(bullet, transform.position + Vector3.up * 0.5f, transform.rotation);
    }
}

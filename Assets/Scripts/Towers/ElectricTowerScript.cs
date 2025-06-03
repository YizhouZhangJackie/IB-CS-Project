using UnityEngine;

public class ElectricTowerScript : WeaponScript
{
    protected string rarity;
    [SerializeField] private GameObject bullet;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject.Find("ObjectRecorder").GetComponent<ObjectRecorderScript>().addTowers(this.gameObject, 50);
        atkFreq = 2;
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

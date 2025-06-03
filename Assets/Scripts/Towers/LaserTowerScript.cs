using UnityEngine;

public class LaserTowerScript : WeaponScript
{
    protected string rarity;
    [SerializeField] private GameObject laser;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject.Find("ObjectRecorder").GetComponent<ObjectRecorderScript>().addTowers(this.gameObject, 50);
        atkFreq = 3;
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }

    public override void attack()
    {
        Instantiate(laser, transform.position + new Vector3(-10.5f, 0.46f, 0), transform.rotation);
    }
}

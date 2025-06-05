using UnityEngine;

public class LaserTowerScript : WeaponScript
{
    protected int rarity;
    [SerializeField] private GameObject laser;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rarity = 0;
        GameObject.Find("ObjectRecorder").GetComponent<ObjectRecorderScript>().addTowers(this.gameObject, 50);
        atkFreq = 3;

        isMouseDown = false;
        resourceScript = GameObject.Find("ResourceSystem").GetComponent<resourceSystemScript>();
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
        if (isMouseDown && resourceScript.coinAmount > 1000)
        {
            currTime2 += Time.deltaTime;
            if (currTime2 > 3)
            {
                upgradeRarity();
                resourceScript.coinAmount -= 1000;
                currTime2 = 0;
            }
        }
    }

    public override void attack()
    {
        if (rarity == 0)
        {
            Instantiate(laser, transform.position + new Vector3(-10.5f, 0.46f, 0), transform.rotation);

        }
        else if (rarity == 1)
        {
            Instantiate(laser, transform.position + new Vector3(-10.5f, 0.46f, 0), transform.rotation);
            Instantiate(laser, transform.position + new Vector3(-10.5f, 0.46f, 0), transform.rotation);
        }
        else if (rarity == 2)
        {
            Instantiate(laser, transform.position + new Vector3(-10.5f, 0.46f, 0), transform.rotation);
            Instantiate(laser, transform.position + new Vector3(-10.5f, 0.46f, 0), transform.rotation);
        }
    }

    private void OnMouseDown()
    {
        string text = "";
        if (rarity == 0)
        {
            text = "Doubles Damage \n Cost: 1000";
        }
        else if (rarity == 1)
        {
            text = "2 times attack speed \n Cost: 1000";
        }
        GameObject.Find("UpgradeText").GetComponent<UpgradeTextScript>().setText(text);
        isMouseDown = true;
    }

    private void OnMouseUp()
    {
        isMouseDown = false;
        currTime2 = 0;
    }

    public void upgradeRarity()
    {
        if (rarity == 0)
        {
            rarity++;
            GetComponent<SpriteRenderer>().color = new Color(0.2078431f, 0.4617735f, 1);
        }
        else if (rarity == 1)
        {
            rarity++;
            GetComponent<SpriteRenderer>().color = new Color(0.9639499f, 1, 0.2078431f);
            atkFreq /= 2;
        }
    }
}

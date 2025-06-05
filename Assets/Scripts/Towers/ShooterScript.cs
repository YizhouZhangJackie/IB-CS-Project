using UnityEngine;
using UnityEngine.InputSystem;

public class ShooterScript : WeaponScript
{
    protected int rarity;
    [SerializeField] private GameObject bullet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rarity = 0;
        GameObject.Find("ObjectRecorder").GetComponent<ObjectRecorderScript>().addTowers(this.gameObject, 50);
        atkFreq = 1;

        isMouseDown = false;
        resourceScript = GameObject.Find("ResourceSystem").GetComponent<resourceSystemScript>();
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
        if (isMouseDown && resourceScript.coinAmount > 200)
        {
            currTime2 += Time.deltaTime;
            if(currTime2 > 3)
            {
                upgradeRarity();
                resourceScript.coinAmount -= 200;
                currTime2 = 0;
            }
        }
    }

    public override void attack()
    {
        if (rarity == 0)
        {
            Instantiate(bullet, transform.position + Vector3.up * 0.5f, transform.rotation);
        }
        else if (rarity == 1)
        {
            Instantiate(bullet, transform.position + Vector3.up * 0.5f, transform.rotation);
            Instantiate(bullet, transform.position + Vector3.up * 0.5f, transform.rotation);
        }
        else if(rarity == 2)
        {
            Instantiate(bullet, transform.position + Vector3.up * 0.5f, transform.rotation);
            Instantiate(bullet, transform.position + Vector3.up * 0.5f, transform.rotation);
            Instantiate(bullet, transform.position + Vector3.up * 0.5f, transform.rotation);
        }
    }

    private void OnMouseDown()
    {
        string text = "";
        if (rarity == 0)
        {
            text = "Doubles Damage \n Cost: 200";
        }
        else if (rarity == 1)
        {
            text = "1.5 times Damage, Doubles Health \n Cost: 200";
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
            GameObject.Find("ObjectRecorder").GetComponent<ObjectRecorderScript>().towerToHealth[this.gameObject] = 100;
        }
    }
}

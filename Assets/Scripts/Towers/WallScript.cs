using Unity.VisualScripting;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    protected int rarity;
    private bool isMouseDown;
    private float currTime2;
    private resourceSystemScript resourceScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rarity = 0;
        GameObject.Find("ObjectRecorder").GetComponent<ObjectRecorderScript>().addTowers(this.gameObject, 100);
        resourceScript = GameObject.Find("ResourceSystem").GetComponent<resourceSystemScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isMouseDown && resourceScript.coinAmount > 200)
        {
            currTime2 += Time.deltaTime;
            if (currTime2 > 3)
            {
                upgradeRarity();
                resourceScript.coinAmount -= 200;
                currTime2 = 0;
            }
        }
    }

    private void OnMouseDown()
    {
        string text = "";
        if (rarity == 0)
        {
            text = "Heal and Doubles Health \n Cost: 200";
        }
        else if (rarity == 1)
        {
            text = "Heal and Double Health \n Cost: 200";
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
            GameObject.Find("ObjectRecorder").GetComponent<ObjectRecorderScript>().towerToHealth[this.gameObject] = 200;

        }
        else if (rarity == 1)
        {
            rarity++;
            GetComponent<SpriteRenderer>().color = new Color(0.9639499f, 1, 0.2078431f);
            GameObject.Find("ObjectRecorder").GetComponent<ObjectRecorderScript>().towerToHealth[this.gameObject] = 400;
        }
    }
}

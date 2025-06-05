using UnityEngine;

public class placableScript : MonoBehaviour
{
    public bool flag = true;
    private float timer = 0.1f;

    public int cost;
    resourceSystemScript script;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        script = GameObject.Find("ResourceSystem").GetComponent<resourceSystemScript>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(script.coinAmount < cost)
        {
            timer = 0.1f;
            flag = false;
            GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 0.4705882f);
        }
        if(timer <= 0)
        {
            flag = true;
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.4705882f);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Tower")
        {
            timer = 0.1f;
            flag = false;
            GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 0.4705882f);
        }
    }

    private void OnDestroy()
    {
        if (flag)
        {
            script.coinAmount -= cost;
        }
    }
}

using UnityEngine;

public class WallScript : MonoBehaviour
{
    protected string rarity;    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject.Find("ObjectRecorder").GetComponent<ObjectRecorderScript>().addTowers(this.gameObject, 50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

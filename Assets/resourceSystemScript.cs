using UnityEngine;

public class resourceSystemScript : MonoBehaviour
{
    public float coinAmount;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coinAmount = 200;
    }

    // Update is called once per frame
    void Update()
    {
        coinAmount += Time.deltaTime * 10;  
    }
}

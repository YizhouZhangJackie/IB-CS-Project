using UnityEngine;

public class laserScript : MonoBehaviour
{
    private float duration = 0.5f;
    private float currTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;
        if(currTime >= duration)
        {
            Destroy(gameObject);
        }
    }
}

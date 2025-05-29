using System.Runtime.CompilerServices;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    protected int atkFreq;
    private float currTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    protected void Update()
    {
        currTime += Time.deltaTime;
        if (currTime >= atkFreq)
        {
            currTime = 0;
            attack();
        }
    }

    virtual public void attack()
    {

    }
}

using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    private Slider slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateHealthBar(float percent)
    {
        slider.value = percent * 100;
    }
}

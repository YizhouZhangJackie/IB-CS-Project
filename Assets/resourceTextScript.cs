using TMPro;
using UnityEngine;

public class resourceTextScript : MonoBehaviour
{
    [SerializeField] private GameObject resourceSystem;
    [SerializeField] private TMP_Text messageText;
    [SerializeField] private GameObject waveSystem;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        messageText.SetText( "Coins: " + Mathf.Floor(resourceSystem.GetComponent<resourceSystemScript>().
            coinAmount) + "\nWave: " + waveSystem.GetComponent<WaveSystemScript>().waveNum);
    }
}

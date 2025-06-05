using TMPro;
using UnityEngine;

public class UpgradeTextScript : MonoBehaviour
{
    [SerializeField] private TMP_Text messageText;
    
    public void setText(string text)
    {
        messageText.SetText("Upgrades: " + text);
    }
}

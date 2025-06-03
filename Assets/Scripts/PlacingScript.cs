using UnityEngine;
using UnityEngine.UIElements;

public class PlacingScript : MonoBehaviour
{
    [SerializeField] GameObject[] allTowers = new GameObject[4];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void placeStructure(int objectNum, Vector3 position)
    {
        position.z = 0.5f;
        Instantiate(allTowers[objectNum], position, transform.rotation);
    }
}

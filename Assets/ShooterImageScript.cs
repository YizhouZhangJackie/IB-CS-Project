using UnityEngine;
using UnityEngine.InputSystem;

public class ShooterImageScript : MonoBehaviour
{
    [SerializeField] private GameObject shooterPrefab;
    bool flag = false;
    private GameObject temp;
    public Camera mainCamera;
    Vector3 position;
    void Update()
    {
        if (flag)
        {
            position = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            position.z = 1;
            position.y = -1.37f;
            temp.transform.position = position;
        }
    }
    private void OnMouseDown()
    {
        temp = Instantiate(shooterPrefab, mainCamera.ScreenToWorldPoint(Input.mousePosition), transform.rotation);
        flag = true;
    }

    private void OnMouseUp() 
    {
        flag = false;

        GameObject.Find("PlacingSystem").GetComponent<PlacingScript>().placeStructure(0, temp.transform.position);

        Destroy(temp);
    }
}

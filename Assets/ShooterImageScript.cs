using UnityEngine;
using UnityEngine.InputSystem;

public class ShooterImageScript : MonoBehaviour
{
    [SerializeField] private GameObject shooterPrefab;
    bool flag = false;
    private GameObject temp;
    public Camera mainCamera;
    Vector3 position;
    [SerializeField] private GameObject enemySpawningSystem;
    void Update()
    {
        if (flag)
        {
            position = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            position.z = 1;
            position.y = -1.37f;
            position.x = Mathf.Max(enemySpawningSystem.GetComponent<EnemySpawningScript>().rightMostX, position.x);
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

        if (GameObject.Find("ShooterImagePrefab(Clone)").GetComponent<placableScript>().flag)
        {
            GameObject.Find("PlacingSystem").GetComponent<PlacingScript>().placeStructure(0, temp.transform.position);
        }
        Destroy(temp);
    }
}

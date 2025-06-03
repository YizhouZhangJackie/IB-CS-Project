using UnityEngine;

public class ElectricTowerImageScript : MonoBehaviour
{
    [SerializeField] private GameObject electricTowerPrefab;
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
        temp = Instantiate(electricTowerPrefab, mainCamera.ScreenToWorldPoint(Input.mousePosition), transform.rotation);
        flag = true;
    }

    private void OnMouseUp()
    {
        flag = false;

        if (GameObject.Find("ElectricTowerImagePrefab(Clone)").GetComponent<placableScript>().flag)
        {
            GameObject.Find("PlacingSystem").GetComponent<PlacingScript>().placeStructure(3, temp.transform.position);
        }
        Destroy(temp);
    }
}

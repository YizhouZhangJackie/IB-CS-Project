using UnityEngine;

public class WallImageScript : MonoBehaviour
{
    [SerializeField] private GameObject wallPrefab;
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
        temp = Instantiate(wallPrefab, mainCamera.ScreenToWorldPoint(Input.mousePosition), transform.rotation);
        flag = true;
    }

    private void OnMouseUp()
    {
        Destroy(temp);
        flag = false;
    }
}

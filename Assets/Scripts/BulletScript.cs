using UnityEngine;

public class BulletScript : MonoBehaviour
{
    protected int bulletSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bulletSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * bulletSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collission)
    {
        Debug.Log("collission");
        Destroy(collission.gameObject);
        Destroy(this.gameObject);
    }
}

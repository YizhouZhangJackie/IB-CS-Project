using UnityEngine;

public class BulletScript : MonoBehaviour
{   
    protected int bulletSpeed;
    protected int pierce;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bulletSpeed = 5;
        pierce = 1;
    }

    // Update is called once per frame
    protected void Update()
    {
        transform.Translate(Vector2.left * bulletSpeed * Time.deltaTime);
        if (pierce <= 0 || transform.position.x < -20)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collission)
    {
        if (collission.gameObject.tag == "Enemy")
        {
            pierce--;
        }
    }

}

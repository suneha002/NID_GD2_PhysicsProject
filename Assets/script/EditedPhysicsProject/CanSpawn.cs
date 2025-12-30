using UnityEngine;

public class CanSpawn : MonoBehaviour
{
    public float speed = 2f;
    public float maxHeight = 5f;

    float startY;

    void Start()
    {
        startY = transform.position.y;
    }

    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;

        if (transform.position.y >= startY + maxHeight)
        {
            Destroy(gameObject);
        }
    }
}

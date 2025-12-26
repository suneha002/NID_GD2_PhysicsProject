using UnityEngine;

public class bubble : MonoBehaviour
{
    public float speed = 1.5f;
    public float destroyY = 6f;

    void Update()
{
    transform.position += Vector3.up * speed * Time.deltaTime;

    if (transform.position.y > destroyY)
    {
        Destroy(gameObject);
    }
}
void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Spike"))
    {
        Destroy(gameObject);
    }
}
}
